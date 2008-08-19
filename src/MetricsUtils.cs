using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardScore = "open-v2";
        public const long BurstBatches = 6776;
        public const long CacheBatches = 6572;
        public const double DefaultWidth = 33.38;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitBudget = 662;
        public const double BaseSpan = 58.32;
        public const long SoftFactor = 6185;

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
