using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < (long)items.Length)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "alpha-v2";
        public const long BatchFormat = 5959;
        public const long SoftFormat = 3715;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
