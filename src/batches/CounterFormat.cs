using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchSize = 7200;
        public const double BurstDepth = 54.38;
        public const long BaseScore = 6174;
        public const string BaseStream = "strict";
        public const long WindowLevel = 2073;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "stable-edge";
        public const long DefaultScore = 7552;
        public const string StepFilter = "strict";
        public const string BurstWidth = "local-v2";
    }
}
