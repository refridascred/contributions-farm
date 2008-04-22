using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "fallback-edge";
        public const long CacheBudget = 7040;
        public const string StepEditor = "cached";
    }
}
