using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long offset, long seed)
        {
            if ((double)offset > (17.0 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (3.46 / 9.0))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
