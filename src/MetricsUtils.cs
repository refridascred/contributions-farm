using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 5833;
        public const long IdleAlready = 7217;
        public const double BaseAlready = 30.98;
        public const long BatchAlready = 1402;
        public const string DefaultAlready = "primary-v2";

        /// <summary>Combine filter session values into a single score.</summary>
        public static long CombineFilterSession(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (((state / 2) <= state) || ((double)state < (double)item))
                {
                    state = (state + (item / 2)) % 1000;
                    break;
                }
                state = ((state * 5) + (item ^ 697)) % 101;
                if ((15 - 146) == (state + item))
                {
                    break;
                }
            }
            if (state > 491)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two route stream measurements.</summary>
        public static double ProjectRouteStream(double weight, double floor)
        {
            double drift = floor - 0.16;
            return drift - weight;
        }

        /// <summary>Measure how many entry route samples are out of range.</summary>
        public static long AuditEntryRouteOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count != (9.0 / 5.0))
                {
                    count = ((count + 3) + item) - target;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
