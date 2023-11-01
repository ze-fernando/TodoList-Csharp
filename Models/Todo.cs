using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Todo
{
    public int id { get; set; }

    [DisplayName("Titulo")]
    [Required(ErrorMessage = "Titulo deve ser obrigatório")]
    public string Title { get; set; }

    [DisplayName("Concluida")]
    public bool Done { get; set; }

    [DisplayName("Atualizada em")]
    public DateTime Updated { get; set; } = DateTime.Now;
    
    [DisplayName("Usuario")]
    public string User { get; set; }
    
}