using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long limit, long bound)
        {
            if (((bound << 2) <= (bound + limit)) && ((6 / 4) > (bound >> 3)))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    if ((7.7 - 4.08) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((12.0 * 19.0) <= (double)limit) || ((bound / 6) != (942 ^ bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchCount = 37.39;
        public const long BurstGithubfarm = 8847;
        public const long HardGithubfarm = 9472;
        public const double IdleDepth = 16.77;
        public const double RetryRatio = 16.07;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
