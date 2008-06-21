using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Synced,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
