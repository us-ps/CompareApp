using CompareApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareApp.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private MainModel _model;

        public string Content
        {
            get { return _model.FileContent; }
            set 
            {
                _model.FileContent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Content)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
