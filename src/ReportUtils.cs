using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor - floor) >= (35 % 24))
            {
                return 6;
            }
            else
            {
                if ((floor + bound) > 95)
                {
                    return 1;
                }
                else
                {
                    if (((double)bound > (8.1 * 9.3)) || ((10.0 + 4.5) <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.59 > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if ((1 ^ bound) == (bound ^ offset))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) <= (offset % 60))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 63) != (0 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >> 1) != (offset & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long GradeCacheAccount(long origin, long limit)
        {
            if ((limit / 4) < (8 << 2))
            {
                return 6;
            }
            else
            {
                if (limit < 0)
                {
                    return 4;
                }
                else
                {
                    if (!((double)917 == (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long anchor = 355;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 5) + (bound >> 2)) % 255) + reading;
            }
            if (anchor < 4)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
