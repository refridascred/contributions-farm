using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = total + total;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long RetryTimeout = 975;
        public const string LimitInterval = "alpha-1";
        public const long LimitDepth = 872;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
