using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultOrder = 79.91;
        public const long BurstCount = 5483;
        public const string HardLevel = "strict-1";
        public const double LimitOrder = 40.97;
    }
}
