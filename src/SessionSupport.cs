using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 10.37;
        public const string BatchCount = "legacy";
        public const string MaxOrder = "open-edge";
        public const long MinOrder = 8055;
        public const double HardSpan = 77.3;
    }
}
