using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 1110;
        public const double LimitFilter = 88.29;
        public const long CacheFilter = 9844;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
