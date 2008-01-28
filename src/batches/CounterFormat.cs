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

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 54;
            foreach (long entry in items)
            {
                if ((double)entry >= (0.4 - 5.03))
                {
                    acc = (acc - acc) % 65521;
                }
                else
                {
                    acc = (acc - (9 >> 5)) % 255;
                }
                if ((acc / 3) < (entry << 3))
                {
                    break;
                }
            }
            return acc;
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
