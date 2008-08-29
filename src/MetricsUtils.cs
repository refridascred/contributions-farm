using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Pending,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2793;
        public const long LimitEditor = 7789;
        public const long LimitTimeout = 1127;
        public const long HardRatio = 6235;
        public const long RetryInterval = 8261;
    }
}
