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

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (floor * 5.49)) - rate;
            }
            else
            {
                drift = drift + (floor / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor - drift)) + (double)(long)i;
            }
            return drift + 7.22;
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
