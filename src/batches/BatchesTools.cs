using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
