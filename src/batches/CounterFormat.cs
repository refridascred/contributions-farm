using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate record stats samples.</summary>
        public static long ScoreRecordStats(long[] series)
        {
            long state = 995;
            foreach (long cell in series)
            {
                state = state ^ (state & 31);
                if (((9.0 / 7.0) == (double)cell) || ((double)cell >= 2.5))
                {
                    break;
                }
            }
            if (state < 571)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 66.13;
        public const double CacheDepth = 1.48;
        public const long LimitBatches = 8381;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
