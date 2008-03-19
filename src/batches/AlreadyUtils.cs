using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank editor contributi input into a small class.</summary>
        public static long GradeEditorContributi(long limit, long floor)
        {
            if ((floor + limit) == (limit * 5))
            {
                return 5;
            }
            else
            {
                if (limit >= (1 - floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 2) == (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor / 2) > (floor >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Stale,
            Pending,
            Active,
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
