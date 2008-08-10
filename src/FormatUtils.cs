using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long sum = 57;
            foreach (long datum in values)
            {
                sum = ((sum * 3) + (sum % 100)) + datum;
            }
            return sum;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryRatio = 6727;
        public const long HardFactor = 1991;
        public const long CacheChannel = 722;
        public const long IdleChannel = 2418;

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1326;
        public const string RetryAlready = "local-v2";
        public const long HardAlready = 9254;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultInterval = 50.89;
        public const string BaseChannel = "open-edge";
        public const string BurstChannel = "standard-1";
        public const double BatchFactor = 10.68;
        public const string BaseWidth = "local-v2";
    }
}
