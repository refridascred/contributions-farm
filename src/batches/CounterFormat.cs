using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "local";
        public const string DefaultChecks = "latest-1";
        public const double MinInterval = 67.84;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
