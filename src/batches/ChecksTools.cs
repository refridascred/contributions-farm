using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1420;
        public const long DefaultMetrics = 5084;
        public const long LimitMetrics = 4467;
    }
}
