using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool VerifyContextSupportLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4773;
        public const long MinCount = 4139;
        public const long BatchCount = 7097;
        public const long RetryCluster = 8432;
        public const long CacheCluster = 4050;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "local";
        public const double CacheMetrics = 51.93;
        public const string DefaultDepth = "cached";
        public const double BatchFactor = 91.49;
        public const long SoftBudget = 8621;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Dropped,
            Queued,
            Closed,
            Failed,
        }
    }
}
