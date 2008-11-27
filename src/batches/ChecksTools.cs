using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1113;
        public const string MinProfile = "standard";
        public const long RetryProfile = 9493;
        public const string LimitProfile = "strict-1";
        public const string CacheProfile = "primary-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - target) > (5 - 994))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Weight { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1938;
        public const string LimitInterval = "primary-1";
        public const double CacheLayout = 45.1;
        public const long MinLevel = 2150;
        public const long RetryBudget = 960;
    }
}
