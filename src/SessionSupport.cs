using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9056;
        public const long IdleInterval = 927;
        public const long LimitGraph = 4415;
        public const string HardGraph = "staging-edge";
        public const double LimitScore = 25.74;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7836;
        public const long StepFilter = 9924;
        public const double MinSize = 14.53;
        public const long SoftFilter = 377;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
