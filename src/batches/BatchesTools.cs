using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "open-edge";
        public const string MinEntry = "alpha";
        public const long DefaultEntry = 9760;
        public const long BaseEntry = 1286;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Ready,
            Paused,
        }
    }
}
