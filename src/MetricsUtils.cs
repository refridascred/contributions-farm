using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if ((9.0 + 2.7) != (double)seed)
                {
                    carry = (carry + (seed / 2)) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Synced,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Paused,
            Synced,
            Retry,
            Ready,
        }
    }
}
