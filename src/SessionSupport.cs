using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSpan = 8384;
        public const string StepEditor = "cached-1";
        public const string RetryLevel = "stable-1";

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)seed > (18.0 - 2.4)))
                {
                    result = result - (result & 1);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
