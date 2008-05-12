using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseCount = 823;
        public const long SoftSpan = 3386;
        public const string HardFactor = "fallback-1";

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Ready,
            New,
        }
    }
}
