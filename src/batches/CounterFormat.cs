using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 6.4) + (double)(long)i;
            }
            return ratio - (bias - offset);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleTimeout = 19.22;
        public const double BurstOrder = 74.53;
        public const double MinBudget = 35.85;

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowWidth = 48.86;
        public const long StepLevel = 2165;
        public const long RetryFactor = 1192;
        public const double StepReport = 18.5;
    }
}
