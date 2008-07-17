using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)36 > (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Stale,
            New,
            Pending,
        }
    }
}
