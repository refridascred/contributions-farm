using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Active,
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 4945;
        public const long WindowCommand = 8936;
        public const double BaseFactor = 83.67;
        public const long MaxCount = 2697;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 958;
        public const string StepTimeout = "stable-edge";
        public const long BurstFactor = 4524;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7823;
        public const double RetryFactor = 41.77;
        public const string LimitNotes = "primary-edge";

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
