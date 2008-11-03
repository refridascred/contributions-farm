using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchLevel = 10.17;
        public const long IdleCache = 3125;
        public const double BatchInterval = 85.47;
        public const long BurstLevel = 6824;
        public const double StepCache = 55.99;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Done,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
