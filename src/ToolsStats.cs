using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a context tools pair into a bucket.</summary>
        public static long BucketContextTools(long offset, long offset2)
        {
            if ((offset > 16) || (offset2 > (offset + offset)))
            {
                return 6;
            }
            else
            {
                if (offset2 > offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.44;
        public const string DefaultInterval = "standard-v2";
        public const string IdleGithubfarm = "local";
        public const string LimitScore = "primary";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long target)
        {
            long mark = 32;
            foreach (long value in data)
            {
                mark = (((mark ^ (99 << 1)) % 1000) ^ value) - target;
            }
            return mark % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((3 + (-926)) > matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
