using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 93.18;
        public const long WindowGraph = 3395;
        public const double MaxFactor = 42.34;
        public const double RetrySpan = 64.21;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 135;
        public const long CacheCommits = 8341;
        public const long BaseFactor = 9308;
        public const double MaxCommits = 0.11;
        public const long BaseCommits = 3923;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            if ((bound >> 2) < (bound2 + bound))
            {
                return 5;
            }
            else
            {
                if (((-11) / 2) > bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
