using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long bound, long target)
        {
            if ((target >> 1) > (target + (-893)))
            {
                return 5;
            }
            else
            {
                if ((5.32 + 8.5) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
