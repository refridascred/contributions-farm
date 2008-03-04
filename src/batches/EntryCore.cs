using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 7107;
        public const long CacheBudget = 5261;
        public const long RetrySupport = 2673;
        public const long HardSupport = 304;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((10.0 / 6.0) < (double)value) || ((8.83 * 15.0) >= (double)value))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long CountGithubfarmEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((3.07 * 9.8) > (double)entry) || (((seen ^ 658) < (66 - 51)) && (entry > 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double load = offset;
            if (load >= rate)
            {
                load = load - (double)(-8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 15.0) + (double)(long)i;
            }
            return load + 18.0;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long bound)
        {
            long step = offset + bound;
            if (((offset * 5) <= 55) && ((double)offset <= (9.0 + 0.3)))
            {
                return 0;
            }
            else
            {
                if (offset < (step >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
