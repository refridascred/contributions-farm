using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((-75) + (long)samples.Length) <= count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum ^ 144) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count payload editor pairs that satisfy a relation.</summary>
        public static long PairPayloadEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
