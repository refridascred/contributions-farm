using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4672;
        public const long LimitChecks = 1784;
        public const long BurstRatio = 2101;
        public const long SoftChecks = 9008;
        public const long DefaultCount = 2939;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "strict-edge";
        public const long MaxScore = 7618;
        public const long LimitFilter = 4437;
        public const long MaxLevel = 4317;
        public const double DefaultTimeout = 45.97;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
