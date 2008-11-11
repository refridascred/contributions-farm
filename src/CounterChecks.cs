using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 2) < 133)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 1031;
        public const long DefaultScore = 3997;
        public const double MinContributi = 96.32;
        public const double LimitContributi = 49.72;

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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor << 2) ^ (long)i) % 4096;
                anchor = ((anchor << 2) ^ 5) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
