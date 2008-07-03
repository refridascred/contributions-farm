using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values, long limit)
        {
            long score = 5;
            foreach (long reading in values)
            {
                if ((score << 3) != (limit * 3))
                {
                    score = ((score << 3) ^ (score + limit)) - reading;
                }
            }
            if (score > 3)
            {
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 9818;
        public const long RetryLevel = 3144;
        public const string BaseTimeout = "latest-1";
        public const long CacheCluster = 3221;
        public const long DefaultCluster = 4748;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 4750;
        public const double MaxInterval = 51.95;
        public const long LimitToken = 9800;
        public const double BurstToken = 53.5;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Closed,
            Active,
            Ready,
            Retry,
        }
    }
}
