using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary-v2";
        public const long HardContributi = 6126;
        public const long BaseContributi = 1716;
        public const long RetryRatio = 6607;

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "fallback-v2";
        public const long DefaultReport = 5042;
        public const double LimitCount = 42.98;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
