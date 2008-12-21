using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "latest-v2";
        public const long SoftTimeout = 7021;
        public const double BatchSupport = 46.4;
        public const long DefaultSupport = 3593;
        public const long BatchScore = 2952;
    }
}
