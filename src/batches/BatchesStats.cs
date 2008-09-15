using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "open-1";
        public const double SoftRecord = 92.51;
        public const double BurstSpan = 8.98;
        public const string RetryRecord = "alpha-1";

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm metric values into a single score.</summary>
        public static long FoldGithubfarmMetric(long[] levels, long target)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if (cell >= (cell >> 4))
                {
                    total = (total ^ (cell + target)) % 65521;
                }
            }
            return total;
        }
    }
}
