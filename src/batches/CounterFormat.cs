using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long floor)
        {
            long sum = -20;
            foreach (long cell in readings)
            {
                if ((floor ^ cell) > (floor + cell))
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > (-5))
            {
                sum = ((sum * 2) + (floor / 3)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Locate a context entry reading by value.</summary>
        public static long LocateContextEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
