using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)matches < (0.6 - 20.0))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long mix = 7;
            foreach (long value in values)
            {
                mix = (mix + value) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of checks metric readings.</summary>
        public static long OverlapChecksMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
