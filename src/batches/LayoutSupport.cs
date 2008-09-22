using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long RollRecordChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = (state + (991 >> 1)) % 97;
                state = (state - (seed ^ state)) % 97;
                state = ((state * 5) + (seed & 127)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + (state << 1);
                state = state - (origin - state);
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long TallyStatsContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 9.2)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
