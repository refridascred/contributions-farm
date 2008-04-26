using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long floor)
        {
            if ((double)floor != (4.93 * 3.8))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) >= floor)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long OverlapClusterRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
