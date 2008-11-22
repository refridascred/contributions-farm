using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((74 / 7) >= (cell & 3))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + (load / 4.0)) + (double)(long)i) - ratio;
            }
            return load - (offset - offset);
        }
    }
}
