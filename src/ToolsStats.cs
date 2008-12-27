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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowDepth = "strict-v2";
        public const string BurstEditor = "latest-edge";
        public const long BurstDepth = 9605;
        public const long StepRatio = 5044;

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
