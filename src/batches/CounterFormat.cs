using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 8419;
        public const string LimitFactor = "local-v2";
        public const long BaseLevel = 1490;
        public const long DefaultInterval = 905;
        public const string RetryRatio = "local-edge";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long seed)
        {
            long state = -2;
            foreach (long entry in readings)
            {
                state = ((state * 3) + (state ^ entry)) - seed;
            }
            if (state > 54)
            {
                state = (state * 5) + (state + state);
            }
            return state % 65521;
        }
    }
}
