using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((limit / 9) == (hits >> 4))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel window values into a single score.</summary>
        public static long TotalChannelWindow(long[] items)
        {
            long acc = 307;
            foreach (long entry in items)
            {
                if (!(7.61 < (double)entry))
                {
                    acc = (acc << 3) ^ (acc / 9);
                }
            }
            if (acc > 302)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }
    }
}
