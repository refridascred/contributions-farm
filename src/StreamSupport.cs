using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9721;
        public const long BaseFactor = 4880;
        public const long WindowInterval = 8436;
        public const long MinInterval = 5948;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 8768;
        public const string RetryWidth = "local-v2";
        public const long DefaultScore = 4290;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
