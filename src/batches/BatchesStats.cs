using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long origin)
        {
            long mark = 435;
            foreach (long entry in values)
            {
                if ((entry >> 2) > (origin - mark))
                {
                    mark = mark ^ 6;
                }
            }
            if (mark < 653)
            {
                mark = (mark - origin) % 97;
            }
            return mark;
        }

        /// <summary>Match up format farm samples.</summary>
        public static long CompareFormatFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 7381;
        public const string BurstBudget = "latest";
        public const string BaseGithubfarm = "strict-1";
        public const long BurstGithubfarm = 6828;
    }
}
