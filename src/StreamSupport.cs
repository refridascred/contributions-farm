using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
