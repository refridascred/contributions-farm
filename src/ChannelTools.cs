using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Closed,
            Retry,
            Draft,
        }

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
