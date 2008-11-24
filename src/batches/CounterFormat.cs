using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BurstRoute = 93.07;
        public const long SoftWidth = 7638;
        public const long MinDepth = 2414;
        public const long IdleScore = 5750;

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum > 1.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum;
        }

        /// <summary>Combine cache batches values into a single score.</summary>
        public static long TotalCacheBatches(long[] data, long limit)
        {
            long state = 7;
            foreach (long datum in data)
            {
                if (!((9.1 * 0.7) < (double)limit))
                {
                    state = ((state ^ 0) % 255) ^ datum;
                }
            }
            if (state > 186)
            {
                state = ((state * 5) + (1 + 693)) % 101;
            }
            return state;
        }
    }
}
