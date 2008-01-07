using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "open-1";
        public const long MinBudget = 9098;
        public const string BaseRoute = "staging-v2";
        public const string StepSize = "local-1";
        public const long HardRoute = 722;

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (state * 5)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Paused,
            Stale,
            Locked,
            Ready,
        }
    }
}
