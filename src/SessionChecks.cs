using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Failed,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 7599;
        public const string WindowProfile = "fallback-edge";
        public const string HardScore = "local-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "staging";
        public const string StepSpan = "cached-1";
        public const long CacheGraph = 8967;
        public const long StepTimeout = 1267;
        public const string RetryInterval = "legacy-v2";

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state + floor) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
