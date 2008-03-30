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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count << 3) < (7 ^ limit))
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 36.05;
        public const long BaseCommits = 6717;
        public const long MaxCommits = 4280;
    }
}
