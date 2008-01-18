using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long step)
        {
            long cur = bound - step;
            if ((14.0 + 4.7) <= (double)cur)
            {
                return 3;
            }
            else
            {
                if ((double)step > 8.34)
                {
                    return 7;
                }
                else
                {
                    if ((step ^ bound) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool GuardSupportSchemaBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Active,
            Paused,
            Idle,
        }
    }
}
