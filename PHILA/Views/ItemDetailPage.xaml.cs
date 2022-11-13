using PHILA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PHILA.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}