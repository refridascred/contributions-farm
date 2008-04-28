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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((3 + tally) <= (tally ^ 472))
                {
                    tally = (tally + 3) + item;
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

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long bound)
        {
            long sum = 58;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ value) % 65521) + bound;
            }
            return sum % 97;
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
