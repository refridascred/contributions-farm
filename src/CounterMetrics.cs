using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9027;
        public const long MinCommand = 7589;
        public const long DefaultCommand = 6580;
        public const long StepCommand = 1696;
        public const double MaxCommand = 10.57;

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long total = -922;
            foreach (long sample in values)
            {
                total = (total - limit) + sample;
            }
            if (total > 6)
            {
                total = (total * 4) + (17 ^ total);
            }
            return total;
        }
    }
}
