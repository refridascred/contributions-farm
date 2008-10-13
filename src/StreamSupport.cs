using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of already account readings.</summary>
        public static long ScoreAlreadyAccount(long[] readings)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (result + item) % 101;
            }
            if (result > 12)
            {
                result = (result ^ (result << 3)) % 65521;
            }
            return result;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long FoldQueueNotes(long[] items, long limit)
        {
            long state = 0;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state + (limit & 63)) - (long)i;
                }
                if (limit < (value * 3))
                {
                    state = (state ^ ((-13) * 3)) % 255;
                }
            }
            if (state < 83)
            {
                state = state - (state - limit);
            }
            return state;
        }
    }
}
