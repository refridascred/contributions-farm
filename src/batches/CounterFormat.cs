using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 92.84;
        public const long WindowInterval = 1376;
        public const double HardCount = 38.99;
        public const long StepTimeout = 4605;
        public const long MaxWindow = 5231;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Active,
            Failed,
            Ready,
            Done,
        }
    }
}
