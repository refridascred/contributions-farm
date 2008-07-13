using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Draft,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 38.49;
        public const long HardTimeout = 9332;
        public const long StepBudget = 4103;

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + rate;
            }
            return mean - (mean + floor);
        }
    }
}
