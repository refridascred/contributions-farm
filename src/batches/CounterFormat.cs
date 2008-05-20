using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "fallback-edge";
        public const string HardCounter = "strict";
        public const long WindowCounter = 1906;
        public const long IdleDepth = 67;
    }
}
