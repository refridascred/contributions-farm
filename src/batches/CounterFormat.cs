using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long AuditGraphCommitsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (778 > hits)
                {
                    hits = ((hits + 2) ^ datum) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values, long bound)
        {
            long result = -750;
            foreach (long reading in values)
            {
                if ((399 - 75) > (reading << 3))
                {
                    result = ((result ^ result) % 101) + bound;
                }
                else
                {
                    result = result + (long)values.Length;
                }
            }
            return result;
        }

        /// <summary>Count filter tools pairs that satisfy a relation.</summary>
        public static long PairFilterToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
