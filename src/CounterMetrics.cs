using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((bound ^ matches) < 149)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= 13.0)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch filter pair into a bucket.</summary>
        public static long SortBatchFilter(long target, long seed)
        {
            long cur = target - seed;
            if ((seed + target) != (cur + cur))
            {
                return 0;
            }
            else
            {
                if (!((double)cur >= (7.0 - 1.08)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Dropped,
            Stale,
            Active,
        }
    }
}
