using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 4570;
        public const string IdleOrder = "strict-1";
        public const double StepOrder = 53.67;
        public const long LimitRatio = 6775;
        public const long HardRatio = 9583;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "local-1";
        public const long BurstRatio = 9889;
        public const long MaxTimeout = 9132;
        public const long MaxSchema = 4031;
        public const long MinSchema = 2388;
    }
}
