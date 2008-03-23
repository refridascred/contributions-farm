using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-1";
        public const double HardSpan = 52.4;
        public const long RetryWindow = 2798;
        public const long IdleInterval = 6830;
        public const string BatchScore = "legacy-edge";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long offset)
        {
            long step = target + offset;
            if ((6.7 * 18.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if ((offset % 7) >= step)
                {
                    return 0;
                }
                else
                {
                    if (target > (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultRatio = 5.14;
        public const long LimitInterval = 9746;
        public const string IdleTools = "alpha-1";
        public const long HardRatio = 869;
    }
}
