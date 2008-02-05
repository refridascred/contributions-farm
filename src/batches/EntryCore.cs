using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((long)items.Length + entry) == (matches + matches)) && (((matches >> 3) <= (37 >> 4)) && ((1.37 * 1.3) < (double)entry)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
