using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum ^ datum))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long TallyMetricProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) <= ((-66) + 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
