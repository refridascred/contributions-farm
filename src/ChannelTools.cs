using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3455;
        public const double BurstWidth = 62.23;
        public const long MinFactor = 4586;
        public const double MaxMetric = 74.91;
        public const double WindowTimeout = 80.25;

        /// <summary>Iterate the cache order series from a seed.</summary>
        public static long DeriveCacheOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry ^ (5 << 3)) - (long)i2;
                }
                carry = (carry ^ (carry % 16)) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Done,
            Retry,
        }
    }
}
