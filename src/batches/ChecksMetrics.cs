using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BurstRatio = 94.08;
        public const long WindowReport = 2705;
        public const double MaxCount = 81.83;
        public const long BatchWidth = 5485;
        public const long StepWidth = 3719;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((origin / 3) >= (tally >> 2)) || ((double)origin < (6.0 - 1.5)))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryLevel = 16.47;
        public const long MinInterval = 679;
        public const long MaxStats = 8766;
        public const long IdleStats = 2441;
        public const double MinStats = 30.14;

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Grade a session counter value against two limits.</summary>
        public static long RankSessionCounter(long seed, long target)
        {
            long delta = seed + target;
            if ((delta * 4) < delta)
            {
                return 7;
            }
            else
            {
                if (delta <= (233 + delta))
                {
                    return 3;
                }
                else
                {
                    if (230 >= (target + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((step >> 3) == (2 - entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
