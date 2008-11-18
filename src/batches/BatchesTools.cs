using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7596;
        public const double IdleCount = 48.89;
        public const string BurstSize = "standard-v2";

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values, long bound)
        {
            long state = 85;
            foreach (long cell in values)
            {
                if ((3.9 > (double)cell) && ((state + bound) == (62 % 3)))
                {
                    state = (state - (bound + cell)) % 255;
                    state = state - (bound - cell);
                }
                if (((cell & 255) >= (92 ^ state)) && ((cell >> 1) <= (cell ^ 27)))
                {
                    state = state + (state - cell);
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
