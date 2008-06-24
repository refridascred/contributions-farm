using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinLevel = "latest-edge";
        public const double BurstAccount = 86.13;
        public const long WindowAccount = 8068;
    }
}
