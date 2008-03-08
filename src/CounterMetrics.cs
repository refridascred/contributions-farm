using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)28 > (double)seed)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double bias = (double)312 / 7.0;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
