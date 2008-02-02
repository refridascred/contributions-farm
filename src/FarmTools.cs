using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "primary-1";
        public const long MinCount = 7526;
        public const string MinDepth = "standard-v2";

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Stale,
            Idle,
            Pending,
        }
    }
}
