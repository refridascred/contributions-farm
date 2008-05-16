using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - 729) > (result & 15))
                {
                    result = result ^ (61 * 4);
                }
                else
                {
                    result = (result * 2) + (limit >> 5);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long ClassifyQueueLayout(long origin, long offset)
        {
            if (!((double)origin < (9.3 - 8.68)))
            {
                return 2;
            }
            else
            {
                if ((9 & 3) <= origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)95 == (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-1) - 8) < (offset % 12))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
