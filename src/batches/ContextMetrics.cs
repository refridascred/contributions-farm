using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Rank { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 794;
        public const double LimitWidth = 55.62;
        public const long SoftMetrics = 4374;

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double drift = (double)((-306) << 3);
            if (drift <= (bias2 * 5.53))
            {
                drift = (drift + (0.51 - 11.0)) - bias;
            }
            return drift - bias2;
        }
    }
}
