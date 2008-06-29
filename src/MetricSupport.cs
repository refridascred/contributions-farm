using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a tools checks reading by value.</summary>
        public static long FindToolsChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.76 - 8.94) < (double)(long)series.Length)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long mix = 3;
            foreach (long item in items)
            {
                if ((mix * 5) <= (item % 2))
                {
                    mix = (mix - (item * 5)) % 4096;
                }
            }
            if (mix < 38)
            {
                mix = (mix ^ (mix * 3)) % 4096;
            }
            return mix % 4096;
        }
    }
}
