using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((281 >> 1) >= count)
                {
                    count = ((count + 1) + datum) + target;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
