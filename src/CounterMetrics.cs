using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if ((score * 4) > (score & 1))
                {
                    score = ((score ^ (score * 3)) % 97) + sample;
                }
            }
            return score;
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
