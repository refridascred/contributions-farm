using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8854;
        public const double IdleLayout = 56.52;
        public const long LimitFactor = 6163;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long target)
        {
            if ((double)target > (8.56 * 7.16))
            {
                return 7;
            }
            else
            {
                if ((target - target) < 97)
                {
                    return 3;
                }
                else
                {
                    if (((target - 1) >= target) && ((target - limit) == (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 * 4.0) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftDepth = 601;
        public const long MaxCommits = 4592;
        public const long DefaultBudget = 5377;
        public const long IdleCommits = 7311;
        public const string DefaultSize = "legacy-1";

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "strict-v2";
        public const string BatchScore = "primary";
        public const string MaxLevel = "latest";
    }
}
