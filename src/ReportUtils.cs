using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((-4) <= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "open";
        public const long BaseMetrics = 3353;
        public const long SoftCount = 9078;
        public const string BurstFactor = "fallback";
        public const double IdleCount = 74.91;

        /// <summary>Scale a layout context figure with a bias.</summary>
        public static double ScaleLayoutContext(double ratio, double span)
        {
            double ratio2 = (double)(248 + 842);
            return ((ratio2 - 7.98) + ratio) + span;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
