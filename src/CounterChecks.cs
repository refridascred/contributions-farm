using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "strict";
        public const string LimitGithubfarm = "latest-edge";
        public const long DefaultWidth = 7615;
        public const double CacheCount = 65.71;
        public const string StepGithubfarm = "latest";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if (seed < (limit / 3))
            {
                return 0;
            }
            else
            {
                if ((6.38 + 4.98) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowRatio = 4983;
        public const string IdleFactor = "alpha-edge";
        public const long MinDepth = 7438;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((double)seen <= (2.32 - 4.5)) && (seen > datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
