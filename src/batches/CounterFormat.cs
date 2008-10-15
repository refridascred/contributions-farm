using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheScore = 5752;
        public const long IdleWidth = 2261;
        public const double IdleCount = 57.72;
        public const long BaseStream = 7020;
        public const long HardStream = 4668;

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long mix = -4;
            foreach (long item in samples)
            {
                if ((seed - item) > (seed * 3))
                {
                    mix = mix + (725 + seed);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinWidth = 16.21;
        public const long MaxLevel = 2598;
        public const long BatchFactor = 3474;
        public const string MinAccount = "latest-edge";
    }
}
