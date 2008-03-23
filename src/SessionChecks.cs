using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of batches queue readings.</summary>
        public static long MatchBatchesQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleFactor = 6647;
        public const long MaxLevel = 7748;
        public const string BatchStream = "fallback-v2";
        public const long MinStream = 6907;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Idle,
            Paused,
            Failed,
        }
    }
}
