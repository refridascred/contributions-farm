using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 79.19;
        public const long MinRatio = 1116;
        public const double StepScore = 17.3;
        public const long SoftChannel = 5575;
        public const long MinWidth = 377;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally + 858))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
