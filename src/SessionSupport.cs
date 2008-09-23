using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchWidth = 6052;
        public const long IdleInterval = 1042;
        public const long StepRoute = 6197;
        public const double CacheInterval = 28.01;
    }
}
