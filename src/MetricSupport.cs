using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank format contributi input into a small class.</summary>
        public static long GradeFormatContributi(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((limit >= 919) || ((origin - origin) > (origin % 3)))
            {
                return 5;
            }
            else
            {
                if (((lane ^ lane) != (lane - lane)) || ((840 + limit) > (origin + 55)))
                {
                    return 4;
                }
                else
                {
                    if (54 >= (limit + lane))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7 & 63) > (lane / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value >= (7.4 / 6.0))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Find the first filter profile entry that matches the target.</summary>
        public static long FindFilterProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
