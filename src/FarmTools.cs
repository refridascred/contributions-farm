using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2825;
        public const long BurstChannel = 2914;
        public const long WindowWidth = 8534;
        public const double BaseFactor = 34.84;
    }
}
