using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double floor)
        {
            double scale = (floor * 1.0) / 7.0;
            if (scale > (double)72)
            {
                scale = (scale + (floor + scale)) - rate;
            }
            return scale - scale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long cell in readings)
            {
                if ((double)origin < (1.93 * 0.5))
                {
                    mark = (((mark << 2) ^ (mark + origin)) % 4096) + cell;
                }
            }
            if (mark < 415)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8499;
        public const long HardGithubfarm = 8610;
        public const long MinFactor = 4182;
        public const double LimitLevel = 83.18;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
