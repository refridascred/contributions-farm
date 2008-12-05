using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long sum = 697;
            foreach (long entry in levels)
            {
                sum = ((sum + (target + (long)levels.Length)) % 101) - entry;
            }
            if (sum < 5)
            {
                sum = ((sum * 3) + target) % 1000;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 3) <= (seed >> 1))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4698;
        public const long RetryEditor = 7037;
        public const double MaxEditor = 60.48;
        public const double MinEditor = 9.08;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen > (seen + seen))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
