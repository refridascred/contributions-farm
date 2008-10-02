using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "fallback";
        public const long WindowCommand = 4488;
        public const long IdleCommand = 4072;
        public const string BatchFactor = "staging";
        public const string MaxSpan = "open-edge";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
