using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long limit)
        {
            if (((1.9 + 6.6) >= (double)offset) || ((limit << 2) <= limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit == (6.3 / 5.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum * 2) <= datum)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 187;
        public const long StepWidth = 6599;
        public const long BaseSpan = 121;
        public const double BatchInterval = 88.14;
        public const string LimitDepth = "standard-1";

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Stale,
            Queued,
        }
    }
}
