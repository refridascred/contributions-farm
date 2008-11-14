using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((1 ^ offset) > 904)
                {
                    result = ((result << 3) ^ offset) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ 81) % 255) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
