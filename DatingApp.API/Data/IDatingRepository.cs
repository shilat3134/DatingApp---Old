using System.Threading.Tasks;
using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class; //instead of create separated methods for add user and photo
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll(); //true is there were changes to save, otherwise false
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}