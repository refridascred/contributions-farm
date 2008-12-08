using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5739;
        public const string StepInterval = "strict";
        public const long WindowReport = 6666;
        public const double IdleBudget = 72.07;
        public const double MinReport = 58.63;

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "open";
        public const double RetryBudget = 37.44;
        public const long BaseProfile = 8949;
        public const string IdleProfile = "alpha";

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSize = 78.06;
        public const double DefaultRoute = 89.89;
        public const double LimitRoute = 30.12;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 40;
        public const long HardContributi = 4512;
        public const long HardBudget = 3611;
        public const long DefaultCount = 522;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
