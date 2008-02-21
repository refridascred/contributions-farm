using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long sum = 60;
            foreach (long reading in values)
            {
                if ((5.7 - 9.7) < (double)reading)
                {
                    sum = ((sum << 2) ^ reading) % 1000;
                }
                if ((sum & 31) == (1 & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 224;
            foreach (long value in values)
            {
                if (((34 & 7) > (state & 255)) || ((state ^ 7) < (636 - state)))
                {
                    state = (state ^ (value >> 2)) % 255;
                }
                else
                {
                    state = (state + 2) % 1000;
                }
            }
            if (state > 66)
            {
                state = ((state << 2) ^ (138 + state)) % 4096;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepScore = 1643;
        public const string RetryDepth = "staging-1";
        public const long BatchWindow = 9670;
        public const long DefaultSpan = 4435;
    }
}
