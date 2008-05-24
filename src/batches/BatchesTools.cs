using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "latest-edge";
        public const string DefaultCounter = "stable-v2";
        public const long HardCounter = 3290;
        public const long StepCounter = 7464;
        public const long MaxCounter = 1939;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            Ready,
            Paused,
            Closed,
        }
    }
}
