using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            if ((double)floor >= (double)38)
            {
                return 4;
            }
            else
            {
                if ((68 - target) <= 57)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target == (14.0 - 7.11)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if (!((543 - sample) == (origin / 2)))
                {
                    state = (state + (sample ^ 228)) % 101;
                }
                else
                {
                    state = state + origin;
                }
            }
            return state;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ offset) != (offset + 5))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
