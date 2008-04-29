using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long origin)
        {
            long anchor = 774;
            foreach (long cell in readings)
            {
                if ((double)origin < (double)6)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 1000) - cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count stats filter pairs that satisfy a relation.</summary>
        public static long CompareStatsFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Active,
            Idle,
            New,
        }
    }
}
