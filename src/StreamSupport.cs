using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "latest";
        public const double MinTimeout = 80.67;
        public const string LimitWidth = "legacy-1";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long target, long floor)
        {
            if ((double)683 == (double)floor)
            {
                return 7;
            }
            else
            {
                if ((6.8 * 14.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 8.62;
        public const long RetryContributi = 1867;
        public const long CacheContributi = 8837;
        public const long BaseContributi = 562;
    }
}
