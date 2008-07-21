using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Failed,
            Dropped,
            New,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
