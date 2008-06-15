using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long origin)
        {
            long delta = bound - origin;
            if ((double)delta <= (5.25 - 9.8))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) > (bound - delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9991;
        public const long MaxWidth = 4714;
        public const string BurstWidth = "fallback-edge";

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double load = 2.26;
            return (load + (4.0 + scale)) + floor;
        }
    }
}
