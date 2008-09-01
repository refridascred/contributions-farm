using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 68.93;
        public const string BatchInterval = "primary-1";
        public const long BatchBudget = 2198;
        public const long StepBatch = 9665;
        public const long BaseBatch = 6380;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double offset)
        {
            double weight = offset / 4.0;
            if (weight >= (weight / 2.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + scale;
        }
    }
}
