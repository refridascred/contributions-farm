using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseCount = "stable-v2";
        public const long RetryFactor = 6888;
        public const string HardFormat = "cached-edge";

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long CountCacheQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits - hits) < (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
