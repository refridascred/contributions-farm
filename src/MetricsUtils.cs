using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit * 2) != (step & 63))
            {
                return 2;
            }
            else
            {
                if (step >= (8 - step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Paused,
            Locked,
        }
    }
}
