using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSpan = 6786;
        public const long IdleOrder = 4709;
        public const double MaxOrder = 86.11;
        public const string BaseOrder = "stable";

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
