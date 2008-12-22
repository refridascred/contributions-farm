using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 2991;
        public const double LimitCount = 1.78;
        public const double BatchBudget = 0.17;
        public const string BatchSession = "fallback";

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

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }
    }
}
