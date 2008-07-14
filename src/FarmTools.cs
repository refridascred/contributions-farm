using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitDepth = "legacy";
        public const string BaseRatio = "legacy-edge";
        public const long WindowBudget = 6881;
        public const long DefaultGithubfarm = 9043;
        public const long DefaultDepth = 9801;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Active,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 49.65;
        public const long DefaultSize = 4942;
        public const double DefaultReport = 96.21;
        public const double BaseCount = 4.96;
        public const long RetryReport = 3112;
    }
}
