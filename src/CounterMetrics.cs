using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits support entries.</summary>
        public static long TotalCommitsSupport(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score * 4) + entry) % 65521;
                score = (score + (entry * 2)) % 1000;
                if ((entry > (entry >> 3)) || ((11.0 - 1.0) != (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 61;
            foreach (long item in values)
            {
                state = (state - (item ^ state)) % 101;
            }
            if (state > 82)
            {
                state = (state * 3) + 61;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(8.2 <= (double)count))
                {
                    count = ((count + 3) + datum) - step;
                }
            }
            return count;
        }
    }
}
