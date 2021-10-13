using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using ReactiveUI;
using Unity;

namespace ReactiveUITest
{
    public class ReactiveTestViewModel : ReactiveObject
    {
        IUnityContainer _container;
        IEventAggregator _eventAggregator;

        public ReactiveTestViewModel(IUnityContainer container, IEventAggregator eventAggregator)
        {
            _container = container;
            _eventAggregator = eventAggregator;

            return;
        }
    }
}
