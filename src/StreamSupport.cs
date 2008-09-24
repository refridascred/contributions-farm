using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double mean = offset;
            if (mean >= 1.77)
            {
                mean = (mean + offset) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 1.5) + (double)(long)i;
            }
            return mean + (2.71 / 5.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 996;
        public const long RetryContributi = 4014;
        public const double SoftSize = 64.44;
        public const double IdleFactor = 91.42;
        public const long SoftBudget = 872;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Ready,
            Locked,
            Pending,
        }
    }
}
