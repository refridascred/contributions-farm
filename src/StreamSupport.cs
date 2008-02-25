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

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
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
