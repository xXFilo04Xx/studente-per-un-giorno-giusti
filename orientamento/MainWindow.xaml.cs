﻿using orientamento.Properties;
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

namespace orientamento
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sld1.Minimum = 0;
            sld1.Maximum = 100;
            sld2.Minimum = 0;
            sld2.Maximum = 100;
        }

        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int a = (int)sld1.Value;
            txtnumero.Text =a.ToString();
            int c = (int)sld2.Value;
            int somma = c + a;
            txtsomma.Text = somma.ToString();
            int molt = c * a;
            txtmoltiplicazione.Text = molt.ToString();
            int sot = c - a;
            txtsottrazione.Text = sot.ToString();
  
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int a = (int)sld2.Value;
            txtsecondonumero.Text = a.ToString();
            int c = (int)sld1.Value;
            int somma = c + a;
            txtsomma.Text = somma.ToString();
            int molt = c * a;
            txtmoltiplicazione.Text = molt.ToString();
            int sot = c - a;
            txtsottrazione.Text = sot.ToString();
     
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            sld1.IsEnabled = true;
            sld2.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            sld1.IsEnabled = false;
            sld2.IsEnabled = false;
        }

 
    }
}
