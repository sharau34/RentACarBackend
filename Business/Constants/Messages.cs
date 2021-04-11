﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages // Sabit olduğu için static verdik. Constants sabitler demektir.
    {
        public static string MaintenanceTime = "Sunucu bakımda";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string CarNameInvalid = "Aracın açıklaması 2 karakterden fazla, fiyatı ise 0'dan büyük olmalıdır.";
        public static string CarAdded = "Araç sisteme eklenmiştir.";
        public static string CarDeleted = "Araça sistemden silindi.";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarUpdated = "Araç bilgileri güncellendi";
        public static string UserAdded = "Kullanıcı sisteme eklendi";
        public static string UserDeleted = "Kullanıcı sistemden silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string UsersListed = "Tüm kullanıcılar listelendi";
        public static string CustomerAdded = "Müşteri sisteme eklendi";
        public static string CustomerDeleted = "Müşteri sistemden silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string CarRented = "Araç kiralandı";
        public static string RentDeleted = "Araç artık kiralık değil";
        public static string CarRentsListed = "Kiralanan tüm araçlar listelendi";
        public static string RentUpdated = "Araç kiralama bilgileri güncellendi";
    }
}