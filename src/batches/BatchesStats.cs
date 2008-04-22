using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheBudget = 5453;
        public const string MinStream = "fallback-1";
        public const double CacheStream = 8.75;

        /// <summary>Digest a series of githubfarm editor entries.</summary>
        public static long CombineGithubfarmEditor(long[] levels)
        {
            long score = 92;
            foreach (long item in levels)
            {
                score = ((score ^ (5 % 12)) % 97) ^ item;
            }
            if (score > 78)
            {
                score = ((score * 2) + (score * 3)) % 255;
            }
            return score;
        }

        /// <summary>Count graph batch pairs that satisfy a relation.</summary>
        public static long OverlapGraphBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
