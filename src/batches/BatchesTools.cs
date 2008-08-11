using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long DeriveBatchesEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)92 <= (double)(long)i))
                {
                    total = total ^ total;
                }
                total = (total * 4) + (bound * 3);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
