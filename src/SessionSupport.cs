using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double StepLevel = 93.32;
        public const double LimitRoute = 44.84;
        public const double DefaultWidth = 55.26;
        public const long HardFactor = 3676;
        public const long MinLevel = 382;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Paused,
            Idle,
            New,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
