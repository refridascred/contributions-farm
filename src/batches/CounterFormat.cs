using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "fallback";
        public const long DefaultAccount = 1645;
        public const long WindowAccount = 7163;
        public const string CacheSize = "standard";
        public const long BatchFactor = 6561;

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double mean = (span / 3.0) / 9.0;
            if (mean < span)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean - (double)25;
            }
            return mean + rate;
        }
    }
}
