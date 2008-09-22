using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long origin)
        {
            if ((origin - bound) >= 3)
            {
                return 1;
            }
            else
            {
                if (((bound >> 2) >= origin) && (bound > (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (bound > (bound >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ origin) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry << 1))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 7070;
        public const long MaxLevel = 6858;
        public const long BaseFilter = 1717;
        public const long DefaultInterval = 3865;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix << 3) ^ (mix & 7);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitRatio = 95.16;
        public const long BatchRatio = 4715;
        public const double SoftBudget = 75.56;
    }
}
