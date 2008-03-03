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

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 30.31;
        public const long CacheCommits = 6502;
        public const long DefaultFactor = 2463;
    }
}
