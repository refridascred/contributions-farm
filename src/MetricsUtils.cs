using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "fallback-edge";
        public const long LimitCache = 1436;
        public const string MaxRatio = "strict";
        public const long DefaultCache = 8224;
        public const long BaseLevel = 1096;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value <= (count & 63))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double span)
        {
            double load = gain;
            if (load > span)
            {
                load = load + gain;
            }
            return load + (double)96;
        }
    }
}
