using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)total != (double)target))
                {
                    total = (total << 2) ^ total;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 2950;
        public const long MinSession = 6252;
        public const long MaxSize = 7831;
        public const long RetryTimeout = 6214;
        public const long IdleCount = 1788;
    }
}
