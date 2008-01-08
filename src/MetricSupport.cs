using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 6654;
        public const double SoftLevel = 7.84;
        public const long MaxCommits = 9446;
        public const double BatchCommits = 10.6;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
