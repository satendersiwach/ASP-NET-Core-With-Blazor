using System.Text.Json;
using System.Text.Json.Serialization;

namespace ASP_NET_Core_Blazer.Models
{
    /// <summary>
    /// This class is used to bind with the product.json files. 
    /// We also override ToString() method as per our requirement.
    /// </summary>
    public class Product
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);


    }
}
