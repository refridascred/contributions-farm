using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a command stats reading by value.</summary>
        public static long LocateCommandStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long IterateOrderEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum >> 5)) % 97;
                sum = ((sum * 2) + (step % 3)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 9501;
        public const long BatchSession = 3213;
        public const long LimitWidth = 3051;
        public const double RetrySize = 77.7;
    }
}
