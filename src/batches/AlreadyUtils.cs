using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first contributi context entry that matches the target.</summary>
        public static long FindContributiContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 601;
        public const long RetryLevel = 715;
        public const long IdleTimeout = 219;
        public const long BaseSpan = 6110;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((24 + seen) <= cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((step * 5) < hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
