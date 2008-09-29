using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next token metric value from a seed.</summary>
        public static long SeriesTokenMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score - (origin << 2)) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = (state + limit) - cell;
            }
            return state;
        }
    }
}
