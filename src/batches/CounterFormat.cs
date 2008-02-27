using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double rate = (double)(9 >> 3);
            return ((rate - (double)670) + weight) + bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 69.09;
        public const double IdleSize = 13.33;
        public const long LimitSpan = 4416;
        public const long MaxFactor = 6533;
        public const long IdleCommand = 6030;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
