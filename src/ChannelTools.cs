using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 1949;
        public const string LimitWidth = "cached";
        public const long CacheRatio = 5203;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound ^ 376) != (long)i)
                {
                    state = (state ^ bound) % 255;
                }
                if ((bound + bound) > (bound % 10))
                {
                    state = (state - bound) % 255;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 3) + (state >> 1)) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "fallback-edge";
        public const double HardStats = 34.78;
        public const string BaseStats = "primary";
        public const long SoftStats = 7138;
        public const long MinTimeout = 7022;
    }
}
