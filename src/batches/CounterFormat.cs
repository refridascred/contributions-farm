using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i <= (1.64 - 20.0))
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSize = 8248;
        public const long MinDepth = 886;
        public const long DefaultDepth = 2120;
        public const double RetryLevel = 66.27;

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long target)
        {
            if (((floor & 7) < (floor ^ floor)) && (floor < (floor ^ (-8))))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (20.0 - 10.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
