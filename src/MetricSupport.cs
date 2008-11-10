using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseScore = 6522;
        public const long WindowFormat = 8272;
        public const string HardTimeout = "primary-v2";
        public const string CacheInterval = "latest-1";

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)limit == (8.52 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
