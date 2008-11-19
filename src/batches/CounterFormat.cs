using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue schema samples.</summary>
        public static long TotalQueueSchema(long[] levels, long bound)
        {
            long state = 9;
            foreach (long reading in levels)
            {
                if (((3.7 / 4.0) >= (double)state) && ((state >> 5) != (532 / 9)))
                {
                    state = (state ^ (bound * 3)) ^ reading;
                }
            }
            if (state > (-349))
            {
                state = ((state * 2) + bound) % 65521;
            }
            return state;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
