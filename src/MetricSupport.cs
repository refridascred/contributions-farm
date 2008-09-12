using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (4.0 < (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 5664;
        public const long CacheMetrics = 2136;
        public const double MaxDepth = 50.51;
    }
}
