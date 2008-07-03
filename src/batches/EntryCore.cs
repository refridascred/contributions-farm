using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 938;
        public const long StepLevel = 3741;
        public const string CacheGithubfarm = "fallback-1";
        public const long BurstInterval = 504;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local-1";
        public const long SoftSize = 911;
        public const double StepRatio = 20.19;
    }
}
