using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 8533;
        public const long HardEntry = 167;
        public const long BatchScore = 2114;
        public const long BurstEntry = 3971;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
