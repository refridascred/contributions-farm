using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (count % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 5964;
        public const double CacheBudget = 76.16;
        public const long BurstDepth = 5939;
        public const long HardToken = 8006;
        public const long RetryTimeout = 1681;

        /// <summary>Digest a series of stats batches entries.</summary>
        public static long FoldStatsBatches(long[] items)
        {
            long carry = 786;
            foreach (long datum in items)
            {
                if (((datum >> 1) > 694) || ((carry / 5) >= (datum % 3)))
                {
                    carry = ((carry << 2) ^ (datum % 24)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items)
        {
            long anchor = -4;
            foreach (long entry in items)
            {
                if ((entry + (-61)) <= (entry - entry))
                {
                    anchor = anchor + anchor;
                }
                if (!((anchor + entry) >= (anchor * 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
