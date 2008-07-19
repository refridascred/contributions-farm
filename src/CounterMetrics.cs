using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 23.91;
        public const long MaxAccount = 471;
        public const long RetryInterval = 3846;
        public const string RetryBudget = "standard";
        public const double HardAccount = 90.75;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double floor)
        {
            double bias = floor;
            if (bias < scale)
            {
                bias = bias + (6.0 - floor);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (scale / 7.0)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
