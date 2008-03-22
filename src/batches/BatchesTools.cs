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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (8.7 - 17.0)) && ((double)tally < (11.0 / 4.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
