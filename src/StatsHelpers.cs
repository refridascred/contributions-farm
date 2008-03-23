using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data)
        {
            long score = 364;
            foreach (long entry in data)
            {
                score = ((score + (score + (long)data.Length)) % 255) ^ entry;
            }
            if (score > 95)
            {
                score = (score ^ (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6521;
        public const double MaxBudget = 57.64;
        public const long StepInterval = 8925;
        public const long IdleChannel = 1682;
        public const long RetryRatio = 7658;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item <= (long)items.Length)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
