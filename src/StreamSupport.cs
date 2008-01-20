using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxSpan = 7917;
        public const long StepDepth = 6843;
        public const long SoftRatio = 2560;
        public const long BurstCommits = 6569;

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheDepth = 7609;
        public const long RetryInterval = 6839;
        public const double StepAlready = 0.61;
        public const long BurstAlready = 6269;
        public const long StepWidth = 5075;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
