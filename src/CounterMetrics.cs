using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Idle,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long diff = seed - offset;
            if (6.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((diff <= (seed / 6)) || (71 >= (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
