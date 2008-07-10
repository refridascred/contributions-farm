using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Draft,
            Stale,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long offset)
        {
            long diff = floor - offset;
            if ((double)offset <= (0.8 + 1.6))
            {
                return 0;
            }
            else
            {
                if ((floor % 10) != (diff + floor))
                {
                    return 6;
                }
                else
                {
                    if ((diff * 2) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)diff >= (5.79 + 1.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if (((773 << 2) >= (floor * 5)) || ((double)bound <= (3.25 + 1.4)))
            {
                return 2;
            }
            else
            {
                if (!((double)floor < (9.8 * 8.23)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
