using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Locate a token stats reading by value.</summary>
        public static long SeekTokenStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long mark = 23;
            foreach (long reading in data)
            {
                if ((bound & 63) != (722 ^ bound))
                {
                    mark = (mark - 313) % 255;
                }
                if ((mark > bound) && (mark < reading))
                {
                    mark = mark - (166 + bound);
                }
            }
            if (mark > 49)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 97;
        }
    }
}
