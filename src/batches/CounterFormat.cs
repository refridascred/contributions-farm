using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 1055;
        public const long DefaultSpan = 4575;
        public const long MinStream = 4910;
        public const string SoftScore = "strict";
        public const long BaseRatio = 9626;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5292;
        public const long HardSize = 8942;
        public const long BaseChecks = 613;
    }
}
