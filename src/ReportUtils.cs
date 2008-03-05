using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double gain = (ratio * 10.0) + (bias - bias);
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 5355;
        public const string HardWidth = "cached-edge";
        public const double BurstBuffer = 47.77;
        public const long IdleBuffer = 2225;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long limit)
        {
            long diff = origin - limit;
            if ((origin & 7) > (diff + origin))
            {
                return 2;
            }
            else
            {
                if ((41 + limit) != (origin + limit))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
