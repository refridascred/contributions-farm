using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) >= (origin - count)) && ((origin > entry) || ((entry * 4) <= (entry * 2))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Idle,
            Draft,
            Retry,
            Done,
        }
    }
}
