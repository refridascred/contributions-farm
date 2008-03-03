using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long state = 47;
            foreach (long item in levels)
            {
                if (!((state << 2) > (state ^ state)))
                {
                    state = (state << 3) ^ ((long)levels.Length >> 5);
                }
                if (((state * 5) < state) && ((state + 73) != (item & 255)))
                {
                    state = ((state * 3) + (state << 3)) % 1000;
                }
            }
            if (state < (-843))
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Fold a list of order contributi readings.</summary>
        public static long ScoreOrderContributi(long[] data)
        {
            long sum = 842;
            foreach (long entry in data)
            {
                sum = sum + 608;
                sum = ((sum * 4) + (sum - entry)) % 101;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum < (-9))
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 30.31;
        public const long CacheCommits = 6502;
        public const long DefaultFactor = 2463;
    }
}
