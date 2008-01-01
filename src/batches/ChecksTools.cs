using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache report pair into a bucket.</summary>
        public static long SortCacheReport(long step, long limit)
        {
            long gap = step + limit;
            if ((gap - step) < (gap * 2))
            {
                return 3;
            }
            else
            {
                if (((double)limit != (13.0 + 6.23)) || ((step + limit) <= limit))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
