using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchInterval = 22.02;
        public const long MaxWindow = 218;
        public const string CacheTimeout = "standard";
        public const long DefaultWindow = 3039;
        public const string DefaultTimeout = "alpha-v2";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
