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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long target2)
        {
            long step = target - target2;
            if (target2 <= (target - step))
            {
                return 7;
            }
            else
            {
                if (((target % 3) > (target & 3)) && ((step + 6) <= (target ^ 773)))
                {
                    return 2;
                }
                else
                {
                    if (78 < (step ^ 25))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
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
