using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count > target) || ((count & 7) >= (31 * 2))) || ((6.6 / 3.0) < (double)count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                score = (score - (datum + datum)) % 97;
                score = ((score << 2) ^ (score << 1)) % 4096;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 85.37;
        public const long DefaultCount = 6745;
        public const long RetryBatches = 1868;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
