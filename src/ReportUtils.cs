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

        /// <summary>Count the window record entries that pass the check.</summary>
        public static long TallyWindowRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (33 > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
