using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
