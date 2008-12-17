using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 481;
        public const long MinCommand = 2063;
        public const long RetryInterval = 3590;
        public const long RetryCommand = 20;
        public const string LimitCommand = "standard";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 6024;
        public const string IdleInterval = "fallback-1";
        public const double WindowSpan = 0.35;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total << 3) ^ (434 & 1)) % 97) - (long)i2;
                    total = (total - (total + total)) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
