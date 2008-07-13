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

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double ratio = 3.4;
            if (ratio <= gain)
            {
                ratio = (ratio - (double)6) + floor;
            }
            return ratio + (double)3;
        }
    }
}
