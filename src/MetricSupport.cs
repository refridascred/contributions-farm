using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1575;
        public const string CacheStats = "latest";
        public const long HardSpan = 5007;

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double weight = (double)(2 ^ 4);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight - (offset - weight);
        }
    }
}
