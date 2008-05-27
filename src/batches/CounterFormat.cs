using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "strict-edge";
        public const double MinTimeout = 63.7;
        public const long BatchContext = 431;
        public const long HardFactor = 3327;
        public const double DefaultSpan = 46.77;

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double weight2 = (weight * 5.72) * 6.2;
            if (weight2 < 7.5)
            {
                weight2 = weight2 + (offset / 8.0);
            }
            return weight2 - weight;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 517;
        public const double RetryProfile = 95.9;
        public const long DefaultProfile = 8845;
        public const long LimitWidth = 2470;
        public const string MaxLevel = "open";
    }
}
