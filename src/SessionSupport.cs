using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "strict-edge";
        public const string MinFactor = "fallback-1";
        public const string StepRatio = "primary";
        public const long BurstChannel = 3874;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardLevel = 92.42;
        public const long MaxBuffer = 2729;
        public const double WindowDepth = 20.36;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            New,
            Idle,
            Closed,
        }
    }
}
