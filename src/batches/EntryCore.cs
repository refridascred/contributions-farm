using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultBudget = 2.24;
        public const long MinInterval = 6903;
        public const double CacheSpan = 41.34;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long span = bound - offset;
            if ((offset & 3) <= offset)
            {
                return 4;
            }
            else
            {
                if (bound <= span)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            New,
            Failed,
            Dropped,
            Done,
        }
    }
}
