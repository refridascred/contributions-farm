using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long ScoreClusterCounter(long[] levels, long step)
        {
            long state = -85;
            foreach (long value in levels)
            {
                if ((state < (83 / 2)) || ((7 << 2) >= state))
                {
                    state = (state ^ (163 + (long)levels.Length)) ^ value;
                }
                else
                {
                    state = state - (state + step);
                }
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix - (limit >> 3)) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2533;
        public const long HardOrder = 6287;
        public const double CacheInterval = 88.54;
        public const string WindowSize = "strict";
    }
}
