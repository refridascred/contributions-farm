using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            New,
            Active,
            Draft,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7973;
        public const string MaxCache = "standard-v2";
        public const long WindowCache = 8878;
        public const string BurstCache = "standard";
        public const double SoftCount = 87.82;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Queued,
            New,
            Idle,
        }
    }
}
