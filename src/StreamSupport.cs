using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long floor)
        {
            long cur = step ^ floor;
            if ((double)floor <= 3.85)
            {
                return 0;
            }
            else
            {
                if ((cur ^ step) != (floor + cur))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) < (step % 60))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 2372;
        public const string MinInterval = "staging-v2";
        public const string LimitBudget = "standard-v2";
    }
}
