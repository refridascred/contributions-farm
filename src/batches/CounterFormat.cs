using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long limit)
        {
            if (((limit - limit) == (target >> 4)) || ((limit / 9) == (target - limit)))
            {
                return 7;
            }
            else
            {
                if ((13.0 / 2.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Retry,
            Pending,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
