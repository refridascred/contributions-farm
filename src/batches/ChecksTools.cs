using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4559;
        public const long CacheCommand = 7732;
        public const double RetryTimeout = 91.39;
        public const long WindowCommand = 3911;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally >> 2) < (4 ^ tally)) || (((3.77 / 7.0) >= (double)item) && ((tally + limit) >= (item + 28))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((245 - reading) >= reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long target)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if (((double)target >= (double)entry) && ((double)target > (4.2 / 5.0)))
                {
                    mix = (mix << 2) ^ target;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + target);
                }
            }
            return mix;
        }
    }
}
