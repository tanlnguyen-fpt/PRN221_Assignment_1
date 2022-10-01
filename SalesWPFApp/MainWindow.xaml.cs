using System.Windows;

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool isAdmin = false;
        public MainWindow(bool isAdmin = false)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.DataContext = this;
        }
    }
}
