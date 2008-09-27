using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long acc = -8;
            foreach (long entry in items)
            {
                if (!(entry >= (entry - seed)))
                {
                    acc = (acc << 3) ^ (entry ^ acc);
                }
                if ((entry >> 5) < seed)
                {
                    acc = (acc - (seed / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 74.31;
        public const long MinLevel = 8289;
        public const double WindowScore = 68.21;
        public const double DefaultAccount = 64.1;

        /// <summary>Accumulate cache order samples.</summary>
        public static long WeighCacheOrder(long[] levels)
        {
            long state = 801;
            foreach (long cell in levels)
            {
                state = state - (state >> 1);
                if (((cell % 2) > (cell - cell)) || (((-50) / 7) != (cell / 9)))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state ^ state)) % 101;
            }
            return state;
        }
    }
}
