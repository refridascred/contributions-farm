using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (36 >= (hits + cell))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if (entry >= ((-1) % 12))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of batch cache readings.</summary>
        public static long PairBatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
