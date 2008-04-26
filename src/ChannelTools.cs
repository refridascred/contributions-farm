using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetrySize = "local";
        public const long LimitWindow = 3636;
        public const string BaseSpan = "cached-edge";
        public const double SoftTimeout = 63.08;
        public const long LimitBudget = 2533;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
