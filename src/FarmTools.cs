using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Pending,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "local";
        public const string DefaultCommand = "fallback-v2";
        public const long IdleWidth = 5388;
        public const long RetryFactor = 7218;
    }
}
