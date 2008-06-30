using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheScore = 2769;
        public const double DefaultAccount = 91.05;
        public const long StepAccount = 6308;
        public const double WindowAccount = 54.94;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
