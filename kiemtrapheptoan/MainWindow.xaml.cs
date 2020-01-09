using System;
using System.Collections.Generic;
using System.Linq;
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

namespace kiemtrapheptoan
{
    /* @2020 Copyright by Tiendatmagic */
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_tinh_Click(object sender, RoutedEventArgs e)
        {
            
                if (txt_gt1.Text.Equals("") || txt_gt2.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng kiểm tra thông tin");
                }
                else
                {
                    int a = Convert.ToInt32(txt_gt1.Text);
                    int b = Convert.ToInt32(txt_gt2.Text);

                    if (r1.IsChecked == true)

                        txt_kq.Text = chia(a, b).ToString();
                    if (r2.IsChecked == true)

                        txt_kq.Text = du(a, b).ToString();
                    if (r3.IsChecked == true)
                        txt_kq.Text = mu(a, b).ToString();
                    if (r4.IsChecked == true)
                        txt_kq.Text = txt_gt1.Text + txt_gt2.Text;
                }     
           
        }
        public double chia(double a, double b)
        {
            return a / b;
        }

        public double du(double a, double b)
        {
            return a % b;
        }

        public double mu(double a, double b)
        {
            return Math.Pow(a, b);
        }

        private void Btn_kt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
/* @2020 Copyright by Tiendatmagic */
