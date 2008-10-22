using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 7.18;
        public const long BatchSpan = 7575;
        public const string IdleScore = "legacy";
        public const double DefaultOrder = 7.86;

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowLevel = 2311;
        public const long HardWidth = 6614;
        public const long CacheRoute = 303;
        public const long StepRoute = 6078;
        public const double HardRoute = 90.41;
    }
}
