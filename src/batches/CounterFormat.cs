using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (double)18)
            {
                ratio = ratio - (double)(-682);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (5.72 - bias)) + (double)(long)i;
            }
            return ratio + (double)343;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryFactor = 36.0;
        public const long BatchStats = 3633;
        public const long HardStats = 9043;
        public const double BurstInterval = 59.35;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstScore = "legacy-v2";
        public const double LimitRatio = 98.73;
        public const string MaxCount = "local-1";
        public const long StepLevel = 8623;
        public const string BaseBuffer = "cached-v2";
    }
}
