using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Idle,
            Draft,
            Active,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "open-edge";
        public const double SoftLevel = 52.66;
        public const long DefaultRatio = 5038;

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long GradeRouteMetric(long step, long origin)
        {
            if (((double)step <= 16.0) && (origin > (93 - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin << 1) < (step / 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long state = 245;
            foreach (long sample in levels)
            {
                if ((sample + state) < (sample - state))
                {
                    state = state ^ (state % 8);
                }
            }
            return state;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long MeasureRouteCommitsOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum + count))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
