using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 269;
        public const double MaxSize = 24.25;
        public const long DefaultSession = 291;
        public const string StepWidth = "latest";
        public const double BaseScore = 21.86;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitRatio = 8.62;
        public const long RetryContributi = 1867;
        public const long CacheContributi = 8837;
        public const long BaseContributi = 562;
    }
}
