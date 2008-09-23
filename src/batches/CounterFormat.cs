using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state * 4) + target;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
