using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 6149;
        public const string BatchRecord = "cached-1";
        public const string BatchInterval = "latest-1";
        public const string BaseCount = "stable-edge";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Ready,
            Paused,
            Retry,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
