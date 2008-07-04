using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 4047;
        public const long RetryTimeout = 7532;
        public const double BaseDepth = 34.31;
        public const double CacheEntry = 31.18;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchWidth = 8400;
        public const long BaseMetrics = 8580;
        public const string HardMetrics = "standard";

        /// <summary>Accumulate cache counter samples.</summary>
        public static long TotalCacheCounter(long[] series, long limit)
        {
            long anchor = -94;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + sample) % 65521) + limit;
            }
            return anchor % 97;
        }
    }
}
