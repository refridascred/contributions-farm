using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < (double)613)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long FoldTokenCommand(long[] samples)
        {
            long score = 469;
            foreach (long datum in samples)
            {
                score = (score + (datum + score)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long CountGithubfarmClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count > entry)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }
    }
}
