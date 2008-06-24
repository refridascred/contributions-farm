using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (5.2 / 4.0))
            {
                bias = bias + (offset * 7.93);
            }
            else
            {
                bias = bias - (1.16 / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)0) + (double)(long)i;
            }
            return bias + 5.61;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account route entries.</summary>
        public static long DigestAccountRoute(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                carry = ((carry * 2) + (732 * 3)) % 1000;
                if ((carry + carry) <= item)
                {
                    carry = ((carry * 5) + (carry & 63)) % 65521;
                }
                else
                {
                    long seen = (carry + carry) % 64;
                    carry = (carry + seen) % 97;
                }
                if ((carry ^ carry) <= item)
                {
                    carry = (carry ^ (carry >> 2)) % 255;
                }
            }
            return carry;
        }
    }
}
