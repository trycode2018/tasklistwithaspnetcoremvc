using System.ComponentModel.DataAnnotations;

namespace TaskList.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Preencha a data de vencimento")]
        public DateTime? DataVencimento { get; set; }
        [Required(ErrorMessage ="Preencha a descricao")]
        public string Descricao { get; set; }
        [Required(ErrorMessage ="Selecione a categoria")]
        public string CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        [Required(ErrorMessage ="Selecione o status")]
        public string StatusId { get; set; }
        public Status Status { get; set; }
        public bool Atrasado => StatusId == "aberto" && DataVencimento < DateTime.Today;

    }
}
