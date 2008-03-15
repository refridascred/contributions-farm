using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter stream series from a seed.</summary>
        public static long IterateCounterStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)offset > 1.39)
                {
                    state = (state ^ ((long)i + (long)i)) % 1000;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 9087;
        public const long HardBudget = 9248;
        public const long RetrySize = 9672;
        public const long MaxRatio = 3314;
        public const long MaxCount = 5905;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseBudget = 19.53;
        public const long IdleGraph = 2159;
        public const double RetryGraph = 18.98;
    }
}
