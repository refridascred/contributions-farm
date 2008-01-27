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

        /// <summary>Accumulate stats queue samples.</summary>
        public static long DigestStatsQueue(long[] readings, long seed)
        {
            long mark = -437;
            foreach (long reading in readings)
            {
                if ((seed + seed) >= (1 + 18))
                {
                    mark = (((mark * 3) + (-31)) % 97) - reading;
                }
                else
                {
                    mark = (mark + seed) % 255;
                }
            }
            if (mark > 115)
            {
                mark = ((mark * 5) + (mark >> 5)) % 255;
            }
            return mark;
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
