using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a checks context reading.</summary>
        public static double AdjustChecksContext(double gain, double bias)
        {
            double mean = (double)(8 + (-39));
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 9.9) + (double)(long)i) + bias;
            }
            return mean - (gain + mean);
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data, long limit)
        {
            long mix = 222;
            foreach (long value in data)
            {
                mix = (mix + 7) % 65521;
                mix = (mix + (value + (long)data.Length)) % 97;
                if ((mix * 3) <= (value + value))
                {
                    mix = mix ^ mix;
                }
                if (((limit ^ (-631)) > (value - value)) && ((double)mix >= (double)value))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a profile notes counter forward.</summary>
        public static long IterateProfileNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (1.0 >= (double)(long)i)
                {
                    continue;
                }
                if (((long)i - 632) < (total << 3))
                {
                    total = (total - 55) % 255;
                    total = (total - ((long)i + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
