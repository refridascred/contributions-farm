using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 1693;
        public const long BaseInterval = 8212;
        public const double BatchCommand = 42.25;
        public const double WindowInterval = 38.58;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7588;
        public const double IdleTimeout = 37.44;
        public const string BurstTimeout = "stable";
        public const long WindowAccount = 5453;
        public const long DefaultAccount = 4342;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state - (target + (long)i2)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
