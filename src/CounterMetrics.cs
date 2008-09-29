using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchCount = 6631;
        public const long RetrySpan = 9178;
        public const long CacheStream = 8758;
        public const long SoftStream = 1653;

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool VerifyProfileEditorLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
