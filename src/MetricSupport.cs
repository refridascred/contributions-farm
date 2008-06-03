using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Failed,
            New,
            Active,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitTimeout = 25.33;
        public const long StepScore = 2795;
        public const double LimitEntry = 46.14;
        public const long SoftTimeout = 8297;
        public const long StepEntry = 8660;

        /// <summary>Grade a cache githubfarm value against two limits.</summary>
        public static long BucketCacheGithubfarm(long bound, long offset)
        {
            long step = bound + offset;
            if ((offset + (-7)) >= (offset * 5))
            {
                return 1;
            }
            else
            {
                if ((776 >> 4) >= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
