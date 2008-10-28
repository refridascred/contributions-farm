using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3490;
        public const double MinBatch = 63.79;
        public const double BatchRatio = 2.72;

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftSpan = 90.52;
        public const string DefaultTimeout = "latest";
        public const long WindowOrder = 9090;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Active,
            Locked,
            Retry,
            Synced,
        }
    }
}
