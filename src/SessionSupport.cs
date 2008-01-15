using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double bias)
        {
            double ratio = (rate * 16.0) / 6.0;
            return (ratio - (5.52 - ratio)) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 3162;
        public const double HardBudget = 27.88;
        public const long BatchStats = 7755;
        public const long IdleRatio = 4243;

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheLevel = "local-v2";
        public const long IdleSchema = 2806;
        public const string DefaultTimeout = "latest";
        public const double StepBudget = 56.27;
    }
}
