using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstSpan = 74.22;
        public const long BaseMetric = 4870;
        public const long HardSpan = 4913;
        public const long HardMetric = 7152;
        public const double CacheTimeout = 5.2;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items, long seed)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (total + sample)) - seed;
                if ((double)total == (double)1)
                {
                    total = ((total * 5) + (total & 7)) % 255;
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 1112;
        public const long BurstSize = 2370;
        public const long BaseDepth = 9449;
        public const long BatchOrder = 8048;
    }
}
