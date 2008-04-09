using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Active,
            Locked,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 268;
        public const long StepWidth = 4891;
        public const long StepScore = 9630;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseDepth = 1387;
        public const long BurstRatio = 5516;
        public const long SoftInterval = 3499;
        public const string MinFilter = "alpha-v2";
    }
}
