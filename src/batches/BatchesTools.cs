using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((9 + reading) < (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxCount = 19.63;
        public const double RetryOrder = 90.03;
        public const long LimitFactor = 6025;
    }
}
