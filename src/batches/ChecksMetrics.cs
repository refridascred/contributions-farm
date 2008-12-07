using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((floor > (origin << 1)) && (lane > (lane + lane)))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (8.4 + 9.9))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 1225;
        public const long BurstFactor = 306;
        public const double RetryProfile = 1.86;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheInterval = 4270;
        public const double BurstCount = 66.86;
        public const long MaxDepth = 3503;
        public const double BaseEntry = 18.79;
        public const long IdleEntry = 9869;
    }
}
