using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 55;
            foreach (long item in levels)
            {
                if ((5 <= item) && ((74 << 2) == (item + item)))
                {
                    sum = (sum ^ (sum + item)) % 97;
                }
            }
            return sum % 1000;
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
