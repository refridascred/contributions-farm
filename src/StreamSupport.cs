using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (17.0 < (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)step != (0.56 + 3.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 6949;
        public const string BurstGithubfarm = "latest-v2";
        public const long BatchScore = 9280;
        public const long CacheGithubfarm = 2069;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
