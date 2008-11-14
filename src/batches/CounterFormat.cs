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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
