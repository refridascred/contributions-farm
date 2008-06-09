using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6801;
        public const double BaseQueue = 59.18;
        public const long WindowInterval = 2967;
        public const string LimitQueue = "open";

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1642;
        public const long SoftInterval = 5138;
        public const long BaseInterval = 1349;
        public const long SoftRecord = 7966;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Draft,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
