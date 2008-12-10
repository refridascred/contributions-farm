using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowRatio = 2118;
        public const double WindowWidth = 14.8;
        public const long StepProfile = 1461;
        public const double HardSize = 78.15;
        public const long RetryProfile = 6730;

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
