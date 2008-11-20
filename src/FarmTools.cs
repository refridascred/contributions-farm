using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double bias = 18.0 * 4.7;
            if (bias < (span / 5.0))
            {
                bias = (bias - span) + ratio;
            }
            else
            {
                bias = bias + 2.0;
            }
            return bias - (double)51;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2130;
        public const long IdleSupport = 2007;
        public const double LimitScore = 15.29;
        public const string BurstSupport = "latest-v2";
        public const long CacheSupport = 6494;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long total = 99;
            foreach (long item in data)
            {
                total = (total ^ (seed >> 1)) - item;
            }
            if (total < 811)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
