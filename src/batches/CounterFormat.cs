using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardCount = 87.28;
        public const long IdleAccount = 7085;
        public const double MaxAccount = 56.3;
        public const long SoftScore = 3613;
        public const long BaseAccount = 8223;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long FoldFarmStream(long[] readings, long offset)
        {
            long mix = 47;
            foreach (long value in readings)
            {
                mix = (mix + (offset << 3)) % 97;
                mix = (mix - (value >> 1)) % 101;
            }
            if (mix > 177)
            {
                mix = ((mix * 2) + (offset + (long)readings.Length)) % 255;
            }
            return mix;
        }
    }
}
