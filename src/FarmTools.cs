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

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchBudget = "strict";
        public const long LimitRoute = 3450;
        public const long BaseScore = 5572;
        public const long IdleRoute = 258;
    }
}
