using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3734;
        public const string RetrySpan = "primary-v2";
        public const long DefaultBatch = 8806;
        public const long SoftBatch = 9655;
        public const long CacheRatio = 2543;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "staging-edge";
        public const long SoftBuffer = 7207;
        public const string BatchBuffer = "latest-edge";
        public const long IdleBuffer = 5453;
        public const double MinBuffer = 23.49;

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long IterateFormatStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((0.66 * 1.57) < (double)(long)i)
                {
                    mix = (mix + ((long)i << 3)) % 1000;
                }
                if (mix > (mix + mix))
                {
                    mix = (mix << 2) ^ (mix >> 4);
                    mix = (mix + (35 - 748)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
