using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "local";
        public const string BatchRatio = "stable-1";
        public const long RetryTimeout = 3089;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 5) > hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long bound)
        {
            long state = 2;
            foreach (long value in data)
            {
                state = ((state * 3) + bound) ^ value;
            }
            return state;
        }
    }
}
