using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6824;
        public const long BurstCommits = 9771;
        public const long LimitDepth = 6868;
        public const double MaxTimeout = 14.29;
        public const long IdleBudget = 4591;
    }
}
