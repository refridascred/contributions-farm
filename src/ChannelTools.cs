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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 3986;
        public const long BatchWidth = 7341;
        public const long IdleCluster = 1056;
        public const long HardCluster = 1401;

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
