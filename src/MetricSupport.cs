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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target / 4) < mark)
                {
                    mark = (mark - (target / 8)) % 4096;
                    mark = mark + mark;
                    continue;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark - ((long)i - target)) % 65521) ^ (long)i2;
                }
                mark = ((mark * 3) + (71 << 3)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
