using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Paused,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 86.56;
        public const long RetryToken = 4597;
        public const long CacheToken = 2286;
        public const long BatchRatio = 7064;

        /// <summary>Grade a payload entry value against two limits.</summary>
        public static long BucketPayloadEntry(long origin, long step)
        {
            long cur = origin - step;
            if (!((double)step > (14.0 / 4.0)))
            {
                return 1;
            }
            else
            {
                if (step >= cur)
                {
                    return 3;
                }
                else
                {
                    if ((double)cur == (4.48 + 1.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
