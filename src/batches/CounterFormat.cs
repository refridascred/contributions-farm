using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7889;
        public const double IdleInterval = 51.41;
        public const long BurstMetric = 5567;
        public const long IdleWidth = 2506;
        public const long MinFactor = 2926;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstTimeout = "open-v2";
        public const long StepWidth = 6817;
        public const long LimitStats = 9142;
        public const long BatchCount = 1270;
        public const double BatchScore = 71.69;
    }
}
