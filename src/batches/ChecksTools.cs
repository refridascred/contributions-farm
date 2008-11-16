using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - (double)0) + weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheDepth = 1.37;
        public const long MaxFarm = 6570;
        public const long BatchCount = 8466;
        public const string LimitFarm = "standard";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long seed)
        {
            long mark = 47;
            foreach (long item in items)
            {
                if ((item + 3) < (seed ^ item))
                {
                    mark = (mark * 5) + ((long)items.Length * 2);
                }
                else
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 7)
            {
                mark = ((mark * 5) + (mark << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double drift = span;
            if (drift >= span)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (gain * 4.0);
            }
            return drift - (double)97;
        }
    }
}
