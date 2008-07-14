using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long bound)
        {
            if ((offset * 5) < (5 % 64))
            {
                return 1;
            }
            else
            {
                if (!((429 * 2) < (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
