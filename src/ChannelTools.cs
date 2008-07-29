using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((target - target) <= target)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (((double)state == (double)datum) && (5.7 > (1.0 * 3.78)))
                {
                    state = ((state * 4) + (datum ^ 2)) % 1000;
                }
                if (((double)state < (3.4 - 12.0)) && ((double)state >= (double)datum))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((8 / 6) <= (origin >> 1))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
