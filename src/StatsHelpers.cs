using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 1021;
        public const double IdleDepth = 57.42;
        public const double LimitMetrics = 40.0;
        public const string CacheMetrics = "local";

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryWidth = 76.04;
        public const long SoftToken = 4133;
        public const long HardRatio = 474;
        public const string BurstToken = "local-1";
        public const double BurstLevel = 81.31;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstInterval = 7529;
        public const string HardOrder = "alpha-edge";
        public const double StepOrder = 82.51;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] items)
        {
            long result = -7;
            foreach (long sample in items)
            {
                if ((result + sample) >= (result * 5))
                {
                    result = result - sample;
                }
            }
            return result;
        }
    }
}
