using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Draft,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 44.73;
        public const long BurstPayload = 2203;
        public const long WindowDepth = 5728;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long bound)
        {
            long cur = offset + bound;
            if (((88 + offset) < (bound & 255)) || ((offset / 6) < bound))
            {
                return 2;
            }
            else
            {
                if (((offset ^ offset) > 75) && ((offset - cur) == (cur * 3)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 3) < ((-1) * 5))
                {
                    matches = ((matches + 2) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - offset) >= (offset + offset))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
