using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 54.75;
        public const long MaxLayout = 6675;
        public const string LimitSize = "fallback";
        public const long HardSize = 7914;
        public const long SoftLayout = 5053;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxTimeout = 5882;
        public const double CacheInterval = 92.47;
        public const string StepTimeout = "fallback";
        public const long BaseBatches = 60;
    }
}
