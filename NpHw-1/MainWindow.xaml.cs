using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NpHw_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string ip = Dns.GetHostEntry("ya.ru").AddressList[0].ToString();
            //MessageBox.Show(Dns.GetHostEntry("149.1.1.1").HostName);
            //string url = Dns.GetHostAddresses(ip).ToString();
            //MessageBox.Show(url);
        }

        private void CheckButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var hostEntry = Dns.GetHostEntry(textBox.Text);

                if (textBox.Text == hostEntry.HostName)
                {
                    StringBuilder message = new StringBuilder("IP адреса:\n");
                    foreach (var addres in hostEntry.AddressList)
                    {
                        message.Append(addres.ToString() + "\n");
                    }
                    MessageBox.Show(message.ToString());
                }
                else
                {
                    MessageBox.Show("IP принадлежит:\n" + hostEntry.HostName);
                }
            }
            catch
            {
                MessageBox.Show("Хост не найден");
            }
            
        }
    }
}
