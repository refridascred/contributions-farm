using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Queued,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long acc = -938;
            foreach (long entry in levels)
            {
                if ((acc + acc) < (entry + (long)levels.Length))
                {
                    acc = (acc - entry) % 4096;
                }
                else
                {
                    acc = (acc - (acc / 8)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
