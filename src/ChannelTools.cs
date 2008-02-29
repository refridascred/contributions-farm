using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 1717;
        public const long MinQueue = 1311;
        public const long SoftCount = 5755;
        public const long WindowQueue = 4481;

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (bound * 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 559;
        public const double BatchSupport = 74.94;
        public const double MinSupport = 38.2;
    }
}
