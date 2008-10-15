using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "strict";
        public const long WindowChecks = 4611;
        public const long MaxDepth = 2477;
        public const long HardFactor = 2014;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 7826;
        public const long BurstToken = 3439;
        public const long CacheToken = 5328;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long step)
        {
            if (((21 * 5) != (origin * 3)) && ((2.5 - 13.0) >= (double)step))
            {
                return 3;
            }
            else
            {
                if (((double)origin >= (double)step) || ((double)origin <= 5.16))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
