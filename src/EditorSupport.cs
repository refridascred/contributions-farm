using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-edge";
        public const long DefaultNotes = 7101;
        public const long StepFactor = 8725;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Stale,
            New,
            Draft,
            Paused,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            New,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Ready,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
