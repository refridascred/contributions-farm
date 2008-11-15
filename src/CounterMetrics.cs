using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = (score + (reading & 1)) % 255;
            }
            if (score > 30)
            {
                score = (score + (score >> 5)) % 97;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 1697;
        public const double SoftInterval = 3.02;
        public const long MaxTimeout = 4758;
        public const long BatchRecord = 969;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Done,
        }
    }
}
