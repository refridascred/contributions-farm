using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 909;
        public const long HardBudget = 4672;
        public const string WindowFilter = "cached-edge";

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 3) <= (value - offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
