using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Retry,
            New,
            Active,
            Ready,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Done,
            New,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 84.57;
        public const long IdleCommits = 654;
        public const double WindowInterval = 96.44;
    }
}
