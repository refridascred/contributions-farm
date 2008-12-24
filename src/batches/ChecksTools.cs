using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6614;
        public const long DefaultSpan = 911;
        public const long MinSpan = 5365;
        public const long SoftFormat = 6078;
        public const double WindowFactor = 35.31;
    }
}
