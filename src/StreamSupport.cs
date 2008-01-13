using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstSize = 2623;
        public const long RetrySpan = 8919;
        public const double SoftCommits = 37.8;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            New,
            Pending,
            Ready,
            Failed,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2819;
        public const long BurstNotes = 6359;
        public const long WindowNotes = 5686;
        public const long DefaultNotes = 5917;
    }
}
