using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate batches metrics samples.</summary>
        public static long FoldBatchesMetrics(long[] samples, long floor)
        {
            long sum = -5;
            foreach (long datum in samples)
            {
                sum = (((sum + (9 << 3)) % 255) - datum) - floor;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 54.71;
        public const long CacheRecord = 4207;
        public const long StepRecord = 6958;
        public const double BurstRecord = 52.29;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5669;
        public const double DefaultQueue = 61.66;
        public const double HardQueue = 68.33;
        public const long StepQueue = 6184;
    }
}
