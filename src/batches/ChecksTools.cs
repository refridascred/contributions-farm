using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultCount = "legacy";
        public const long CacheSpan = 5089;
        public const long HardSpan = 2805;
        public const long MaxStats = 6549;
        public const double BaseInterval = 54.64;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardTimeout = 1119;
        public const long RetryNotes = 5070;
        public const long BurstNotes = 1033;
    }
}
