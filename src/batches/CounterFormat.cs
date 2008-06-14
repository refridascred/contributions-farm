using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseInterval = 1299;
        public const double MaxCommand = 43.39;
        public const long WindowCommand = 3404;
        public const long IdleCommand = 4110;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "primary-edge";
        public const double RetryScore = 36.85;
        public const string DefaultBudget = "cached-1";
        public const long LimitReport = 2118;
        public const long BurstSpan = 9214;

        /// <summary>Combine already counter values into a single score.</summary>
        public static long FoldAlreadyCounter(long[] series, long bound)
        {
            long carry = 742;
            foreach (long cell in series)
            {
                if ((61 + bound) < 0)
                {
                    carry = ((carry << 2) ^ (carry ^ 6)) % 1000;
                }
                if ((double)cell >= (double)bound)
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = ((carry * 5) + (carry & 255)) % 97;
            }
            return carry;
        }
    }
}
