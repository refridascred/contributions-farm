using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7036;
        public const long BurstSize = 9530;
        public const long SoftBudget = 3847;

        /// <summary>Adjust a notes route reading.</summary>
        public static double AdjustNotesRoute(double rate, double bias)
        {
            double bias2 = 0.05;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (rate / 2.0);
        }
    }
}
