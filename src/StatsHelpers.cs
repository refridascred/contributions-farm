using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate entry cache readings against a bound.</summary>
        public static bool VerifyEntryCacheLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] values, long offset)
        {
            long acc = 543;
            foreach (long datum in values)
            {
                acc = ((acc ^ (offset - (long)values.Length)) % 65521) - datum;
                acc = (acc * 3) + (long)values.Length;
                if ((long)values.Length < acc)
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long TallyEntryToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally >= (double)item) && ((tally % 12) == (tally + item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSize = "stable-1";
        public const long BatchWidth = 2285;
        public const long CacheBuffer = 3910;
        public const long MaxBuffer = 3652;
        public const long WindowBudget = 1305;
    }
}
