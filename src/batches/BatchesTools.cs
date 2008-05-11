using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardSize = 206;
        public const long BurstTimeout = 5409;
        public const long WindowCommand = 1264;
        public const long HardCommand = 1920;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Synced,
            Stale,
        }
    }
}
