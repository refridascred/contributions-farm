using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryLevel = 2127;
        public const long DefaultToken = 4288;
        public const long BatchInterval = 4143;
        public const double IdleToken = 22.8;
        public const long HardToken = 719;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state << 3) ^ ((long)i2 + state)) % 1000;
                }
                if ((origin >> 5) >= (long)i)
                {
                    state = (state + (origin * 4)) % 65521;
                    state = (state + (9 ^ state)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 4365;
        public const long LimitCommits = 8329;
        public const string CacheCount = "open-v2";
        public const string HardTimeout = "standard-v2";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long bound, long offset)
        {
            long gap = bound + offset;
            if ((double)bound != (double)gap)
            {
                return 5;
            }
            else
            {
                if ((offset - 38) == (bound ^ offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
