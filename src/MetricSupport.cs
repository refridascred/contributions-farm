using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            New,
            Done,
            Paused,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultInterval = 73.18;
        public const string StepBuffer = "fallback";
        public const double MinBuffer = 66.59;
        public const long MaxBuffer = 9564;
        public const double IdleBuffer = 26.3;
    }
}
