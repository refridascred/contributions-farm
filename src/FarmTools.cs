using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next session order value from a seed.</summary>
        public static long SeriesSessionOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Active,
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
