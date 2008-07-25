using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a schema batches pair into a bucket.</summary>
        public static long BucketSchemaBatches(long seed, long target)
        {
            long prev = seed + target;
            if ((seed - seed) > prev)
            {
                return 3;
            }
            else
            {
                if ((target - prev) >= (prev + seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Locked,
            Pending,
            Closed,
            Paused,
        }
    }
}
