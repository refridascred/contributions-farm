using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftScore = 147;
        public const long MinBudget = 5797;
        public const double CacheFarm = 30.95;
        public const long DefaultSize = 4578;
        public const long RetryFactor = 7741;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Pending,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
