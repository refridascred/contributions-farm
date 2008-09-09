using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long total = -9;
            foreach (long sample in data)
            {
                total = (total ^ (8 + sample)) % 101;
            }
            return total;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length + origin) == (tally >> 2))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
