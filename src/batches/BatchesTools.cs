using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits != (4.32 * 5.6)) && !((double)value >= (7.98 - 4.9)))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((count + count) <= count) || (79 < (count / 8))))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
