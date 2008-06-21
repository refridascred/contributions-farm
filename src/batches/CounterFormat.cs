using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Done,
            Locked,
            Retry,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
