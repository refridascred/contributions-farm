using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 2261;
        public const long IdleAlready = 4320;
        public const long CacheAlready = 5981;
        public const long DefaultAlready = 1388;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 8944;
        public const long DefaultDepth = 2946;
        public const double RetryWidth = 61.66;
        public const double IdleFactor = 60.08;
    }
}
