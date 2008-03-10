using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCount = 6163;
        public const string WindowCache = "open-v2";
        public const long BaseCache = 6620;
        public const long DefaultSize = 2058;
        public const string LimitCache = "cached-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "primary";
        public const long HardTools = 5089;
        public const long DefaultTools = 8076;
        public const long CacheTools = 6548;
        public const long MaxTools = 9232;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
