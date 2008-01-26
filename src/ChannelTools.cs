using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 7894;
        public const string MinWindow = "standard-1";
        public const string StepCount = "fallback-edge";
        public const long HardDepth = 5553;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "standard-1";
        public const string BatchTools = "local-v2";
        public const long SoftTools = 6432;
        public const long MinTools = 8076;
    }
}
