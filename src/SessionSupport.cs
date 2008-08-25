using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 1909;
        public const long CacheScore = 4140;
        public const double CacheTimeout = 79.96;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
