using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 4951;
        public const string MaxSize = "alpha-edge";
        public const double MaxScore = 40.8;
        public const string CacheWidth = "legacy";

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count == (8.2 * 6.21))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 4.0) <= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
