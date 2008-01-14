using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate contributi window readings against a bound.</summary>
        public static bool CheckContributiWindowLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a order metrics reading by value.</summary>
        public static long LocateOrderMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches << 2) >= (matches / 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio / 2.0)) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
