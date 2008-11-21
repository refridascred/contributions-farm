using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long origin)
        {
            if ((7.87 * 17.0) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((9.7 / 4.0) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6406;
        public const double RetrySchema = 4.31;
        public const long CacheSchema = 7564;
        public const long RetryBudget = 1602;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
