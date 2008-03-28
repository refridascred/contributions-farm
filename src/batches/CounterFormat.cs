using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long state = 856;
            foreach (long value in readings)
            {
                state = (state - ((long)readings.Length & 1)) % 255;
                state = (state - (state % 3)) % 101;
                if (((state % 60) >= (value << 2)) && ((state + state) != (408 % 2)))
                {
                    state = state + (value & 3);
                }
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (bound % 97)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitBudget = 6740;
        public const long BurstLevel = 9565;
        public const double BurstCommand = 68.8;
        public const long SoftWidth = 641;
    }
}
