﻿using System;

namespace ClassLibrary1
{
    public class Rational : IConvertible
    {
        private Zint n;
        private Zint d;

        public override string ToString()
        {
            this.refresh();
            return "" + n.ToString() + " / " + d.ToString();
        }

        private void refresh()
        {
            int[] nprimes = n.PrimeFactorization();
            int[] dprimes = d.PrimeFactorization();
            int p = dprimes.Length;
            if (dprimes.Length < nprimes.Length)
            {
                p = nprimes.Length;
            }
            int[] newprimes = new int[p];
            int i = 0;
            while (i < nprimes.Length && i < dprimes.Length)
            {
                if (i <= 1)
                {

                }
                else
                {
                    nprimes
                }
                i++;
            }
        }

        public Rational(Zint n, Zint d)
        {
            this.n = n;
            this.d = d;
        }

        public static Rational Random()
        {
            Zint n = Zint.Random();
            Zint d = Zint.RandomPositive();
            Rational r = new Rational(n, d);
            return r;
            //throw new NotImplementedException();
        }

        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}