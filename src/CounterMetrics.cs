using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepFactor = 9954;
        public const double SoftRatio = 6.85;
        public const long BaseBudget = 6108;
        public const long BatchRatio = 9603;
    }
}
