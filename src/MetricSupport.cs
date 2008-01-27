using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (((floor - offset) != (offset ^ lane)) || ((floor + lane) <= offset))
            {
                return 5;
            }
            else
            {
                if (!((14.0 / 5.0) > (double)lane))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank cache order input into a small class.</summary>
        public static long RankCacheOrder(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (((double)cur > (2.4 - 7.1)) && ((origin ^ origin) < (cur - origin)))
            {
                return 1;
            }
            else
            {
                if (cur >= (bound << 1))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
