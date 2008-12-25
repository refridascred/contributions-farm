using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinSize = 9788;
        public const long IdleStream = 2766;
        public const double LimitSize = 84.67;
        public const long DefaultLevel = 3686;
        public const long MinDepth = 7688;

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 493;
        public const double SoftSchema = 56.0;
        public const double MinSchema = 72.9;
        public const string MaxDepth = "alpha-1";
        public const long RetrySpan = 695;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Draft,
            Synced,
            Pending,
        }
    }
}
