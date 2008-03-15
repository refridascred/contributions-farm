using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 46.23;
        public const double BaseEntry = 19.23;
        public const long DefaultSpan = 3556;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 42.1;
        public const double IdleGraph = 93.51;
        public const string HardScore = "strict-v2";
    }
}
