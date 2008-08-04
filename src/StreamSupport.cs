using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowWidth = 69.17;
        public const string BatchCommand = "stable";
        public const double LimitCount = 67.15;
        public const long LimitDepth = 9327;
        public const string WindowCommand = "standard-v2";

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5786;
        public const long BurstCache = 1054;
        public const double IdleCache = 26.91;

        /// <summary>Grade a profile payload value against two limits.</summary>
        public static long BucketProfilePayload(long target, long origin)
        {
            if ((double)target > 6.3)
            {
                return 7;
            }
            else
            {
                if (((target & 255) < (origin - target)) && ((target & 7) == (origin ^ (-702))))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
