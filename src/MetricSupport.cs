using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8388;
        public const long BatchStats = 7101;
        public const string MinScore = "stable";
        public const string DefaultScore = "fallback-edge";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Classify a githubfarm support pair into a bucket.</summary>
        public static long BucketGithubfarmSupport(long floor, long target)
        {
            long edge = floor - target;
            if ((double)floor != (double)edge)
            {
                return 1;
            }
            else
            {
                if (floor >= (target % 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
