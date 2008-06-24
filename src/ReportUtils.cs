using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleSize = "standard-1";
        public const long MinChecks = 9071;
        public const string BatchChecks = "stable-edge";
        public const long SoftSize = 9004;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long RollMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((9.3 / 8.0) >= (double)sum) && ((double)(long)i != (9.4 * 7.58)))
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
