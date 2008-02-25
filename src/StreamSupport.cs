using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order batches sample.</summary>
        public static long SeekOrderBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account graph entries that pass the check.</summary>
        public static long CountAccountGraphHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 1) > 853)
                {
                    hits = ((hits + 3) ^ sample) - floor;
                }
            }
            return hits;
        }
    }
}
