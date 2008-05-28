using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryInterval = 7894;
        public const long StepQueue = 9892;
        public const long LimitWidth = 9177;
        public const long WindowQueue = 3710;
        public const long HardQueue = 2619;

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
