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

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 54.4;
        public const long BaseRatio = 6035;
        public const long LimitGithubfarm = 689;
        public const long RetryGithubfarm = 377;
    }
}
