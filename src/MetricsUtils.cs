using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 28.54;
        public const long IdleWidth = 339;
        public const long BatchTimeout = 7751;
        public const double BatchAlready = 42.7;

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double ratio, double floor)
        {
            double gain = 18.0;
            return (gain - (floor - floor)) + ratio;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 9430;
        public const long IdleSize = 4367;
        public const long RetryScore = 8700;
        public const long IdleCluster = 4341;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
