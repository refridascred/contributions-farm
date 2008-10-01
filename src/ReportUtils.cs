using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a layout checks value against two limits.</summary>
        public static long SortLayoutChecks(long floor, long bound)
        {
            if ((bound - floor) > (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftRatio = "standard-v2";
        public const long BaseLevel = 7889;
        public const long WindowProfile = 1519;
        public const long BaseProfile = 8729;
        public const long BurstProfile = 9883;

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Done,
            Failed,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
