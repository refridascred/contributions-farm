using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 5532;
        public const long HardAlready = 7486;
        public const long MaxCount = 9179;
        public const long StepScore = 4557;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1625;
        public const string LimitWidth = "fallback-1";
        public const double HardCounter = 13.31;
        public const long IdleCounter = 9239;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 2.1)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 736;
        public const long BaseWindow = 9901;
        public const long BaseCount = 1830;
        public const long SoftWindow = 8772;
        public const long RetryBudget = 8395;

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 36.05;
        public const long BaseCommits = 6717;
        public const long MaxCommits = 4280;
    }
}
