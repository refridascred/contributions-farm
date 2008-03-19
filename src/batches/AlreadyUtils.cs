using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Closed,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long bound2)
        {
            if (((bound2 >> 1) < bound2) || (bound2 >= (bound2 - bound2)))
            {
                return 8;
            }
            else
            {
                if ((bound2 << 3) > (bound2 & 127))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 > bound) || ((double)bound != (9.7 + 6.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((750 < (matches / 3)) || ((15.0 + 0.9) == (double)cell)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi queue entries that pass the check.</summary>
        public static long MeasureContributiQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ sample) == (hits % 8))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Synced,
            Queued,
        }
    }
}
