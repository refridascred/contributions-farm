using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8691;
        public const long StepMetric = 7744;
        public const long MinCount = 5063;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Failed,
        }
    }
}
