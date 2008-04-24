using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8086;
        public const double DefaultRatio = 10.24;
        public const long BurstBatches = 3044;
        public const long StepCount = 4636;
        public const long StepBatches = 6153;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long target)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((target + target) <= (mix / 2))
                {
                    mix = ((mix + (mix >> 3)) % 4096) ^ value;
                }
                else
                {
                    mix = (mix + ((-5) % 24)) % 101;
                }
            }
            if (mix < 879)
            {
                mix = mix - 18;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= 55)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
