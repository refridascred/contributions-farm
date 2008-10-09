using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long mark = 379;
            foreach (long item in values)
            {
                if ((double)item == (3.17 * 5.65))
                {
                    mark = mark - (mark + item);
                    continue;
                }
                if (mark >= floor)
                {
                    mark = (mark ^ (floor - floor)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 >= rate)
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - item) >= (item ^ (long)data.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const double MaxDepth = 78.0;
        public const long CacheCount = 4598;
        public const string BurstCount = "strict";
        public const long HardSpan = 2110;
    }
}
