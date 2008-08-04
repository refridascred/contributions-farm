using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long acc = 6;
            foreach (long item in items)
            {
                acc = acc - (item ^ acc);
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc - (item & 3)) % 1000) + (long)i;
                }
                if (((1 << 2) <= acc) && ((5.0 + 0.7) != (double)acc))
                {
                    acc = (acc + (item * 4)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Locate a stream account reading by value.</summary>
        public static long FindStreamAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits ^ hits) != (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
