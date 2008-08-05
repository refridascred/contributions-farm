using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 209;
        public const long DefaultOrder = 8744;
        public const long BurstOrder = 4666;
        public const long IdleOrder = 4739;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 3535;
        public const long StepAccount = 6457;
        public const long DefaultWidth = 2323;
        public const long DefaultFactor = 4294;
        public const double LimitAccount = 4.79;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
