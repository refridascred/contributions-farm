using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = (double)(4 << 2);
            if (weight <= offset)
            {
                weight = (weight + (weight * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleScore = "primary";
        public const double BurstFactor = 23.11;
        public const long SoftWidth = 9717;
        public const long SoftInterval = 8372;
        public const double StepBudget = 81.55;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Failed,
            Draft,
            Active,
        }
    }
}
