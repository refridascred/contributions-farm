using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((45 + sample) >= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

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
