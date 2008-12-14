using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long bound)
        {
            long state = 4;
            foreach (long item in samples)
            {
                long cur = item;
                if ((cur / 3) < state)
                {
                    state = (state << 2) ^ (6 - item);
                }
                state = (state + (bound >> 3)) % 1000;
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long offset)
        {
            if (bound >= offset)
            {
                return 8;
            }
            else
            {
                if ((bound & 15) != (bound / 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Dropped,
            Retry,
            Active,
            Draft,
        }
    }
}
