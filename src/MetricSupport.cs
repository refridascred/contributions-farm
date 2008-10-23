using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long seed)
        {
            if (((93 + seed) < seed) && ((0.4 / 5.0) == (double)floor))
            {
                return 8;
            }
            else
            {
                if ((double)floor == (4.21 / 3.0))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 6850;
        public const string SoftStats = "strict-edge";
        public const long BatchStats = 2562;
        public const string LimitWidth = "latest-v2";
        public const double LimitFactor = 88.61;
    }
}
