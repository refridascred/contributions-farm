using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "local-1";
        public const long BurstCounter = 6544;
        public const string CacheDepth = "strict";
        public const long MinScore = 4923;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Synced,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Iterate the layout token series from a seed.</summary>
        public static long IterateLayoutToken(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
