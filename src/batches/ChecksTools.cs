using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double bias2 = bias - (double)980;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (bias + weight)) - (double)(long)i;
            }
            return bias2 + (double)69;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long mix = 86;
            foreach (long cell in items)
            {
                mix = ((mix << 2) ^ (offset / 2)) % 97;
                if ((offset ^ cell) < (684 ^ cell))
                {
                    mix = (mix * 3) + cell;
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
            }
            return mix % 65521;
        }
    }
}
