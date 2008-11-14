using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch route input into a small class.</summary>
        public static long BucketBatchRoute(long bound, long bound2)
        {
            if (bound < (bound2 + 98))
            {
                return 5;
            }
            else
            {
                if ((6 - bound2) >= bound2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 91.16;
        public const double RetryBatches = 42.47;
        public const double StepLevel = 37.59;
        public const long SoftRatio = 613;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)value >= (2.7 / 4.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
