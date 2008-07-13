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

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

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
