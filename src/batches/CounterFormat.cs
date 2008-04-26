using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((seed & 7) != (count + count)) && ((seed + count) > (cell * 5))) && ((count << 1) == (5 * 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
