using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double mean = floor;
            if (mean <= weight)
            {
                mean = mean + 3.0;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + weight;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 5291;
        public const string MaxSize = "latest-v2";
        public const long MinSpan = 477;
        public const double BurstReport = 77.51;
    }
}
