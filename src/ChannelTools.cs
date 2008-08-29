using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 9065;
        public const string MinStats = "primary-1";
        public const long SoftWidth = 2440;
        public const long SoftScore = 4552;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Done,
            Closed,
        }
    }
}
