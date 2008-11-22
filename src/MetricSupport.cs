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

        /// <summary>Check that every metrics editor entry stays within the limit.</summary>
        public static bool CheckMetricsEditorRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
