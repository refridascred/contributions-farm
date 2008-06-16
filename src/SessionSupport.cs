using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 4707;
        public const long BurstDepth = 7093;
        public const long MinBudget = 5309;
        public const long BatchEntry = 2470;
        public const string IdleEntry = "fallback-v2";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long bound)
        {
            long next = seed - bound;
            if ((next + seed) != (next + 4))
            {
                return 0;
            }
            else
            {
                if ((seed / 4) >= (seed * 3))
                {
                    return 6;
                }
                else
                {
                    if (bound <= (seed ^ 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
