using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 610;
        public const long StepCount = 942;
        public const string CacheSpan = "fallback-1";
        public const double BaseNotes = 92.57;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long offset)
        {
            long carry = 39;
            foreach (long value in series)
            {
                carry = (carry + (offset & 255)) + value;
            }
            return carry % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSpan = 992;
        public const double RetryInterval = 7.74;
        public const double MaxLevel = 46.07;
        public const long MinTimeout = 6642;
        public const long BatchWidth = 8222;
    }
}
