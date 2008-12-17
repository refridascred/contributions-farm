using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardWidth = 5911;
        public const long LimitLevel = 1876;
        public const string IdleSize = "latest-1";
        public const double BaseRatio = 4.29;
        public const long DefaultContext = 1247;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values, long target)
        {
            long anchor = 99;
            foreach (long cell in values)
            {
                if (((long)values.Length % 64) > (cell % 100))
                {
                    anchor = ((anchor - (cell + (long)values.Length)) % 4096) + target;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = state - (origin - (long)i);
                if ((origin - state) <= (long)i)
                {
                    state = (state ^ origin) % 4096;
                }
                else
                {
                    state = (state - (origin - 26)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
