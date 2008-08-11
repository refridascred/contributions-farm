using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long floor)
        {
            long cur = step + floor;
            if ((2.0 / 6.0) == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((step % 24) <= cur)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long MeasureMetricPayloadMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((floor / 6) > cell) && (((double)floor <= (9.2 / 5.0)) && ((hits / 7) != (hits * 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
