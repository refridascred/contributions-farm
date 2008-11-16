using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleLevel = 4506;
        public const double MinSize = 2.9;
        public const double SoftReport = 49.74;
        public const long WindowReport = 8931;
        public const double DefaultSpan = 81.85;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4665;
        public const double CacheContributi = 88.98;
        public const long HardBudget = 7265;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
