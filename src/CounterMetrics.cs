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

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = 3.0 - (offset - rate);
            if (scale >= scale)
            {
                scale = scale - (rate + scale);
            }
            return scale + scale;
        }
    }
}
