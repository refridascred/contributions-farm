using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryScore = 6908;
        public const long BaseStats = 258;
        public const long SoftTimeout = 9973;
        public const long SoftSpan = 8087;
        public const long BurstCount = 9670;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
