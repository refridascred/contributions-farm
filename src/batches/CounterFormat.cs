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

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 77;
            foreach (long entry in levels)
            {
                if ((sum % 12) != (entry ^ sum))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 65521;
                }
            }
            if (sum > 684)
            {
                sum = ((sum * 5) + (68 >> 4)) % 65521;
            }
            return sum;
        }
    }
}
