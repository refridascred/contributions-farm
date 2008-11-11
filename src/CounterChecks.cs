using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (scale + ratio))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - offset)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((mark >> 4) == (mark + floor)))
                {
                    mark = (mark - (floor + mark)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum * 2) > datum))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items)
        {
            long sum = 39;
            foreach (long item in items)
            {
                if ((sum / 5) <= (sum / 8))
                {
                    sum = ((sum ^ sum) % 65521) + item;
                }
                if ((7.0 / 5.0) < (double)sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((939 ^ bound) < (origin - bound))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)(-31))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 67) <= (origin & 127))
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
    }
}
