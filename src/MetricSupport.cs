using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 5) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = ((mark - (mark & 1)) - value) - limit;
            }
            return mark;
        }
    }
}
