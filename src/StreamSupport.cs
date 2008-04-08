using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 6054;
        public const long MaxLevel = 2760;
        public const double DefaultToken = 53.23;
        public const double IdleToken = 73.24;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4614;
        public const long RetrySession = 2022;
        public const string BatchSession = "cached-edge";
    }
}
