using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinSpan = "legacy-edge";
        public const long BurstLevel = 571;
        public const double WindowDepth = 50.82;
        public const double LimitSpan = 76.09;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 6867;
        public const long MaxProfile = 7544;
        public const double HardProfile = 40.15;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 412;
        public const string DefaultChecks = "stable-v2";
        public const long RetryChecks = 6442;
        public const long BaseChecks = 4282;
        public const string WindowRatio = "primary";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
