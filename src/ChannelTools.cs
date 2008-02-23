using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinSize = "fallback-1";
        public const long MinDepth = 3919;
        public const double BatchRecord = 86.73;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstDepth = "alpha-v2";
        public const long DefaultCache = 812;
        public const double IdleCache = 16.54;
        public const long SoftCount = 3231;
    }
}
