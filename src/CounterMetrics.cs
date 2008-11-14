using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((target2 % 2) == (target2 % 12))
            {
                return 8;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Active,
            Draft,
            Closed,
            Paused,
        }
    }
}
