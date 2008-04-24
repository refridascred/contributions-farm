using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Ready,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 1690;
        public const long MinCount = 7179;
        public const long RetryCommits = 6459;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            long gap = offset + origin;
            if (offset >= 23)
            {
                return 5;
            }
            else
            {
                if (((-18) % 60) < origin)
                {
                    return 7;
                }
                else
                {
                    if (gap >= (gap ^ gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 7381;
        public const string BurstBudget = "latest";
        public const string BaseGithubfarm = "strict-1";
        public const long BurstGithubfarm = 6828;
    }
}
