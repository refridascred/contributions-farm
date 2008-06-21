using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stream queue reading.</summary>
        public static double AdjustStreamQueue(double rate, double span)
        {
            double drift = (double)432 * 7.54;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (17.0 * 0.34)) + (double)(long)i) + rate;
            }
            return drift + (span + span);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "open";
        public const long IdleContext = 9705;
        public const long MinContext = 2528;
        public const long SoftContext = 6221;
        public const long HardFactor = 9945;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 7357;
        public const double LimitCommand = 61.77;
        public const long BatchBudget = 8114;
    }
}
