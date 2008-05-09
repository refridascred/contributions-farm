using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((9.0 - 2.6) <= (double)count)
                {
                    count = ((count + 1) + datum) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long sum = 814;
            foreach (long value in series)
            {
                sum = ((sum - ((long)series.Length >> 4)) ^ value) - origin;
            }
            return sum;
        }
    }
}
