using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 5176;
        public const long RetryStats = 1027;
        public const string SoftStats = "primary-1";
        public const double MaxRatio = 7.91;
        public const double LimitSpan = 36.21;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool GuardContributiSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
