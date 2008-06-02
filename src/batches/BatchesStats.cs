using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((150 >> 3) == (entry + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
