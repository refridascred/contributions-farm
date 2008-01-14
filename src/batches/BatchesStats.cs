using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long AuditCommitsCommandOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell < (34 >> 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout context values into a single score.</summary>
        public static long DigestLayoutContext(long[] items, long origin)
        {
            long acc = -149;
            foreach (long cell in items)
            {
                if ((cell & 31) <= origin)
                {
                    acc = (acc * 5) + 369;
                }
            }
            if (acc > 794)
            {
                acc = ((acc * 5) + acc) % 65521;
            }
            return acc;
        }
    }
}
