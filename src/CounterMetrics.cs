using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long origin)
        {
            long acc = 7;
            foreach (long value in values)
            {
                acc = ((acc - (acc % 60)) % 255) + value;
            }
            if (acc < (-43))
            {
                acc = (acc << 2) ^ (origin / 5);
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings, long bound)
        {
            long anchor = -87;
            foreach (long item in readings)
            {
                if ((double)bound < (double)anchor)
                {
                    anchor = ((anchor - ((long)readings.Length % 10)) % 1000) - item;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor ^ bound)) % 65521;
                }
            }
            return anchor % 97;
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
