using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.95 / 3.0) > (double)count)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data)
        {
            long state = 5;
            foreach (long value in data)
            {
                if ((545 - value) < (long)data.Length)
                {
                    state = ((state * 2) + (state % 2)) % 255;
                }
            }
            if (state > (-67))
            {
                state = state + (state ^ state);
            }
            return state % 97;
        }
    }
}
