using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 2408;
        public const long WindowAlready = 6258;
        public const long LimitAlready = 5225;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitSpan = "stable";
        public const double MinRatio = 59.95;
        public const long MaxPayload = 1349;
        public const long IdleLevel = 6830;
        public const string CacheInterval = "strict-1";
    }
}
