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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9266;
        public const long CacheToken = 2078;
        public const string BurstToken = "latest-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 4612;
        public const long CacheScore = 5711;
        public const string MaxEntry = "latest-1";
        public const double WindowEntry = 71.46;
        public const long HardSize = 3447;
    }
}
