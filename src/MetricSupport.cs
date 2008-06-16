using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long limit)
        {
            long state = 87;
            foreach (long item in readings)
            {
                state = ((state * 5) + state) + limit;
                state = state - (-883);
                state = ((state * 4) + item) % 101;
            }
            if (state < (-220))
            {
                state = (state * 2) + (state ^ state);
            }
            return state;
        }
    }
}
