using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support command entries.</summary>
        public static long TotalSupportCommand(long[] data)
        {
            long total = 33;
            foreach (long sample in data)
            {
                if ((total - sample) <= total)
                {
                    total = total + sample;
                }
                if (3.2 >= (double)total)
                {
                    total = ((total * 2) + (sample << 2)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (sample / 9);
                }
                if (((sample - 670) > (total % 3)) && (total <= (sample - total)))
                {
                    total = (total - (total - sample)) % 97;
                }
            }
            if (total < 850)
            {
                total = (total + (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 65;
            foreach (long item in items)
            {
                acc = ((acc * 5) + ((long)items.Length + item)) % 101;
                if ((floor % 60) < floor)
                {
                    acc = (acc - (item >> 1)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Scale a cluster buffer figure with a bias.</summary>
        public static double AdjustClusterBuffer(double scale, double floor)
        {
            double bias = (double)(608 + 28);
            if (bias >= 5.0)
            {
                bias = ((bias - (double)77) + scale) + floor;
            }
            else
            {
                bias = bias + (double)6;
            }
            return bias - (double)1;
        }
    }
}
