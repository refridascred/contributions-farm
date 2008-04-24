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

        /// <summary>Match up format farm samples.</summary>
        public static long CompareFormatFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
