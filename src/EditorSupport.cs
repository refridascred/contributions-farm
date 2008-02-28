using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "open-edge";
        public const long MaxFormat = 5698;
        public const long SoftFormat = 4577;
        public const long SoftWidth = 5170;
        public const double CacheFormat = 8.54;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 7.35;
        public const long StepFarm = 8611;
        public const string BatchFarm = "latest-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitRatio = 17.35;
        public const long BatchScore = 4480;
        public const long RetryWidth = 6298;
        public const long IdleCount = 7430;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Done,
            Pending,
        }
    }
}
