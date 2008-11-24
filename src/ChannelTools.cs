using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 74.85;
        public const long WindowEditor = 3021;
        public const long BurstEditor = 8387;

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 0.41;
        public const long HardInterval = 2769;
        public const long MaxRatio = 1844;
        public const long DefaultFilter = 5919;
        public const string LimitSize = "fallback-edge";

        /// <summary>Roll a profile counter counter forward.</summary>
        public static long StepProfileCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + (3 & 255)) % 65521;
                bool valid = (50 - mix) < (step - 7);
                if ((7.0 <= (double)step) || valid)
                {
                    valid = step <= (7 ^ 176);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
