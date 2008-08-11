using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitSize = "open";
        public const long RetryTimeout = 975;
        public const string LimitInterval = "alpha-1";
        public const long LimitDepth = 872;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading + target) != (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
