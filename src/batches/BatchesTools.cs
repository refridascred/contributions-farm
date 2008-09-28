using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double weight = (8.9 + bias) + (floor + floor);
            return weight - bias;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long acc = 930;
            foreach (long datum in samples)
            {
                acc = ((acc ^ 8) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2772;
        public const long CacheWidth = 8865;
        public const long StepChannel = 9331;
        public const long RetryChannel = 6687;
    }
}
