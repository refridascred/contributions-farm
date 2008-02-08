using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster session entries that pass the check.</summary>
        public static long AuditClusterSessionHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading >= (reading - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a already window pair into a bucket.</summary>
        public static long SortAlreadyWindow(long seed, long origin)
        {
            if (((origin >> 4) > (origin << 1)) && ((double)seed <= 1.0))
            {
                return 0;
            }
            else
            {
                if (origin > 4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 8714;
        public const long MinEditor = 8340;
        public const double IdleScore = 9.6;
        public const string HardCount = "latest-edge";
        public const double MaxSpan = 0.09;
    }
}
