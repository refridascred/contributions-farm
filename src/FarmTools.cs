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

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 3797;
        public const long BatchInterval = 7853;
        public const long LimitLayout = 625;
    }
}
