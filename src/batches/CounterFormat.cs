using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8;
        public const double BaseSpan = 47.62;
        public const long RetryScore = 841;

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double scale = offset;
            return (scale + (double)99) + rate;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Dropped,
            Draft,
            Closed,
            Idle,
        }
    }
}
