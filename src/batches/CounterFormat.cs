using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardTimeout = "alpha-1";
        public const long MaxBudget = 2037;
        public const string MinCount = "strict";
        public const long LimitWindow = 4152;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Closed,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double floor)
        {
            double weight = (double)(904 + 14);
            return (weight + floor) + bias;
        }
    }
}
