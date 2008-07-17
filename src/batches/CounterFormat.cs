using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) < (long)data.Length)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long limit2)
        {
            if (limit >= (limit2 & 255))
            {
                return 0;
            }
            else
            {
                if ((limit / 7) > (limit2 ^ limit2))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit2 != (double)42) || ((15.0 * 17.0) == (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit2 * 3) <= (114 >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(235 < (count + 0)))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }
    }
}
