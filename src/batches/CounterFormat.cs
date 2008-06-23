using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = 36;
            foreach (long value in samples)
            {
                mix = ((mix << 3) ^ (value % 100)) % 101;
                if (mix <= 529)
                {
                    mix = mix + (value + value);
                    mix = ((mix << 2) ^ (value * 2)) % 4096;
                }
                if (((double)value > (5.24 + 20.0)) && ((value ^ 60) < (mix << 1)))
                {
                    mix = mix + (value << 3);
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 2647;
        public const long RetryLevel = 1583;
        public const long BurstFactor = 1111;
        public const long WindowTimeout = 2318;
        public const long BatchEntry = 3713;
    }
}
