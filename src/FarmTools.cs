using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowSpan = "open-1";
        public const double LimitLevel = 87.38;
        public const long MinInterval = 7401;
        public const string DefaultTools = "open";
        public const long SoftInterval = 7130;
    }
}
