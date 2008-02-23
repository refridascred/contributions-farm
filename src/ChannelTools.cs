using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftRatio = 7206;
        public const long SoftFactor = 4894;
        public const double WindowPayload = 98.15;
        public const string HardBudget = "standard-1";

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items)
        {
            long state = 389;
            foreach (long item in items)
            {
                if (!(state <= (state - item)))
                {
                    state = (state << 2) ^ (2 >> 3);
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstDepth = "alpha-v2";
        public const long DefaultCache = 812;
        public const double IdleCache = 16.54;
        public const long SoftCount = 3231;
    }
}
