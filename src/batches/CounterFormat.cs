using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a editor entry reading.</summary>
        public static double AdjustEditorEntry(double rate, double offset)
        {
            double rate2 = (double)(246 << 1);
            if (rate2 >= (offset + offset))
            {
                rate2 = rate2 - (double)389;
            }
            else
            {
                rate2 = rate2 - (5.4 - rate);
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long CountSchemaMetricGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((0.51 * 6.9) >= (double)hits)
                {
                    hits = ((hits + 2) ^ entry) - bound;
                }
            }
            return hits;
        }
    }
}
