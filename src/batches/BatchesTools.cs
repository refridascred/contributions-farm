using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first batch cache entry that matches the target.</summary>
        public static long FindBatchCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (double)seed) || ((seed < (seed + reading)) || ((reading - seed) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
