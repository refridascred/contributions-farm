using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 9929;
        public const double CacheRatio = 24.7;
        public const long BaseDepth = 9031;
        public const long RetryEntry = 9830;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2187;
        public const long RetryGraph = 150;
        public const double BatchGraph = 76.91;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Failed,
            Retry,
            Closed,
            Done,
        }
    }
}
