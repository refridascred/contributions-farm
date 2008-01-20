using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 9734;
        public const double RetryTimeout = 52.12;
        public const double HardLevel = 41.87;
        public const long MaxScore = 9939;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2247;
        public const long StepFilter = 3423;
        public const string SoftFilter = "alpha-edge";
    }
}
