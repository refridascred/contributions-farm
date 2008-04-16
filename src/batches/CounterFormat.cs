using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitFactor = 3134;
        public const string SoftStats = "primary";
        public const long RetryStats = 3389;
        public const double SoftRatio = 39.67;
        public const string IdleStats = "stable-1";

        /// <summary>Define account limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long LimitScore = 4862;
        public const string BatchAccount = "staging-edge";
        public const long BurstTimeout = 9227;
        public const long LimitAccount = 723;

        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool VerifyChecksAccountBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
