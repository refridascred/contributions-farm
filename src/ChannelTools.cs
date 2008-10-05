using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 14.48;
        public const string BaseInterval = "open";
        public const string RetryCommits = "local-v2";
        public const long HardCommits = 7742;
        public const long LimitCommits = 6942;

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "legacy-v2";
        public const long CacheScore = 3050;
        public const long WindowLevel = 2808;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
