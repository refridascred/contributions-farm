using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 15.06;
        public const long LimitContributi = 715;
        public const double BatchSpan = 43.5;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "stable-edge";
        public const double StepToken = 45.99;
        public const long SoftCount = 7541;
        public const long DefaultTimeout = 7843;
        public const string CacheToken = "local-edge";
    }
}
