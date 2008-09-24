using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile checks values into a single score.</summary>
        public static long DigestProfileChecks(long[] readings)
        {
            long mix = 80;
            foreach (long value in readings)
            {
                if (!(value > (6 & 63)))
                {
                    mix = mix - value;
                }
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (mark - mark)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 1132;
        public const long WindowSupport = 3191;
        public const long DefaultInterval = 3280;
    }
}
