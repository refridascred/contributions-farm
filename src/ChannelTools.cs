using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 832;
        public const long MinLevel = 6252;
        public const string SoftLayout = "open-v2";
        public const long WindowLevel = 6554;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8107;
        public const double RetryInterval = 96.75;
        public const string HardEditor = "stable";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry % 5)) % 101;
                if (carry > (origin * 2))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
