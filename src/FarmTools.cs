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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i > 0.3)
                {
                    mark = ((mark << 3) ^ (floor + 265)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + ((long)i + mark)) % 97;
                }
                if ((floor % 97) != ((long)i + 6))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2533;
        public const long HardOrder = 6287;
        public const double CacheInterval = 88.54;
        public const string WindowSize = "strict";
    }
}
