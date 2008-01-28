using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double ratio2 = ratio;
            return ratio2 + bias;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepCount = 3476;
        public const long DefaultBudget = 1548;
        public const long StepMetrics = 9517;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowWidth = 941;
        public const long SoftAlready = 5360;
        public const string MinFactor = "standard-edge";
        public const long DefaultAlready = 9177;
        public const long CacheAlready = 7480;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
