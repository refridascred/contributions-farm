using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long SortMetricsCommand(long seed, long limit)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((limit + limit) >= (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) != (seed / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry / 8) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
