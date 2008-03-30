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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= (count + value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 36.05;
        public const long BaseCommits = 6717;
        public const long MaxCommits = 4280;
    }
}
