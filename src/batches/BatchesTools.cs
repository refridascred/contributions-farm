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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4201;
        public const string BaseMetrics = "open-1";
        public const long MinMetrics = 1411;
        public const long BaseDepth = 4467;
        public const long StepMetrics = 8710;

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
