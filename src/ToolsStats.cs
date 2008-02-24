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

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long TallyCacheWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value / 9) == (matches + 974)) || (value <= (matches + value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
