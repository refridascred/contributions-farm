using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}
