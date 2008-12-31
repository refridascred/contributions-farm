using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9810;
        public const long HardTimeout = 7854;
        public const string IdleScore = "stable-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 62;
        public const double LimitRoute = 37.34;
        public const long WindowRoute = 779;
        public const long WindowLevel = 6089;
        public const long LimitRatio = 8192;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
