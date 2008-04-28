using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (total - bound);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 34;
        public const string BaseCount = "cached-1";
        public const long BatchNotes = 7042;
        public const long MinRatio = 7121;

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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
