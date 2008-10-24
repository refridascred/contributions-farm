using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 57.28;
        public const string MinRatio = "primary-edge";
        public const long BatchInterval = 8865;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchWidth = 9981;
        public const string HardLevel = "local-1";
        public const string BurstFilter = "open-1";
        public const long BurstInterval = 9435;
        public const long LimitBudget = 980;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long CountStatsChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) >= (value & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
