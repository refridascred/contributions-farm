using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long gap = limit - bound;
            if (bound >= (bound + gap))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)gap)
                {
                    return 6;
                }
                else
                {
                    if (((495 - bound) != (limit + 87)) && (limit <= (gap / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats buffer readings.</summary>
        public static long PairStatsBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
