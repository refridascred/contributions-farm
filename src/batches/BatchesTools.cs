using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Retry,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSize = 2073;
        public const long BurstOrder = 975;
        public const long HardLevel = 9722;
        public const double HardSpan = 4.32;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
