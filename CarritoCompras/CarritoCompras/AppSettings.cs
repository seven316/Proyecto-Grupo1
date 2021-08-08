using AppNotas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    public class AppSettings
    {
        public static string ApiFirebase = "https://proyecto-final-ffc8f-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyAKo_qGJyKI57qN8_r7CX3KDWSPHA1Jmbw";


        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/";

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis + "accounts:signInWithPassword?key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                return ApiUrlGoogleApis + "accounts:signUp?key=" + KeyAplication;
            else
                return "";
        }

    }
}
