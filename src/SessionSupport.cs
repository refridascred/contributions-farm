using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "staging";
        public const long LimitRoute = 352;
        public const double RetryRoute = 49.73;
        public const long IdleRoute = 7039;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3634;
        public const long StepBudget = 4943;
        public const string CacheScore = "local";
        public const string LimitReport = "local-edge";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Done,
            Idle,
            New,
            Synced,
        }
    }
}
