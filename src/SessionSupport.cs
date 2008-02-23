using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 62.27;
        public const long SoftFarm = 8826;
        public const string MaxScore = "standard-edge";
        public const long LimitFactor = 1078;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging-1";
        public const long BaseFormat = 762;
        public const long MinFormat = 7648;
        public const long DefaultFormat = 3585;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
