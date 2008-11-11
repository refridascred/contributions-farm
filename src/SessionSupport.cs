using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token context series from a seed.</summary>
        public static long DeriveTokenContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = sum + (sum + sum);
                sum = (sum - (long)i) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples)
        {
            long mix = 11;
            foreach (long cell in samples)
            {
                if (((23 % 8) >= (mix - cell)) || ((mix & 63) <= (cell + mix)))
                {
                    mix = ((mix * 3) + (cell & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
