using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 8203;
        public const long IdleSize = 5556;
        public const string MaxBatch = "standard";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 5703;
        public const double BatchFactor = 97.35;
        public const string SoftContributi = "primary-v2";
        public const long WindowWidth = 8258;

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
