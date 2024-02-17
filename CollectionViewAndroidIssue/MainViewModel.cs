using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CollectionViewAndroidIssue;

public class MainViewModel
{
    public ObservableCollection<string> Items { get; set; } = new()
    {
        "Item 1",
        "Item 2",
        "Item 3",
        "Item 4",
    };

    public ICommand RemoveItemCommand => new Command(RemoveItem);
    public ICommand AddItemCommand => new Command(AddItem);

    void RemoveItem()
    {
        if (Items.Count > 0)
        {
            Items.Remove(Items.Last());
        }
    }

    void AddItem()
    {
        Items.Add($"Item {Items.Count + 1}");
    }
}

