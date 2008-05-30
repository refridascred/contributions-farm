using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 63.5;
        public const long BurstLevel = 9381;
        public const string LimitSize = "local-1";
        public const long BurstTimeout = 3495;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 1627;
        public const long DefaultSize = 1444;
        public const string WindowDepth = "staging-v2";

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
