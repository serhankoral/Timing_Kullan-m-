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
using System.Windows.Threading;

namespace Timing_Kullanımı
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void kayit_Click(object sender, RoutedEventArgs e)
        {
            mesaj1.IsOpen = true;
            ses();
            DispatcherTimer timer1 = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 2)
            };
            timer1.Tick += delegate (object senderx, EventArgs ex)
           {
               ((DispatcherTimer)timer1).Stop();
               if (mesaj1.IsOpen) mesaj1.IsOpen = false;
           };
            timer1.Start();

        }

        private void cikis_Click(object sender, RoutedEventArgs e)
        {
            mesaj2.IsOpen = true;
            ses();
            DispatcherTimer timer2 = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 2)
            };
            timer2.Tick += delegate (object senderx, EventArgs ex)
            {
                ((DispatcherTimer)timer2).Stop();
                if (mesaj2.IsOpen) mesaj2.IsOpen = false;
            };
            timer2.Start();
        }

        private void yazi_buyut_Click(object sender, RoutedEventArgs e)
        {

            DispatcherTimer timer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 0,0,1)
            };
            timer.Start();
            timer.Tick += delegate (object senderx, EventArgs ex)
              {
                  yazi.FontSize++;
                  if (yazi.FontSize == 100) timer.Stop();
              };



        }
        public void ses()
        {
            MediaPlayer media = new MediaPlayer();
            media.Open(new Uri("muzik.wav", UriKind.Relative));
            media.Play();
        }
    }
}
