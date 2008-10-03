using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Pending,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 2950;
        public const long MinSession = 6252;
        public const long MaxSize = 7831;
        public const long RetryTimeout = 6214;
        public const long IdleCount = 1788;
    }
}
