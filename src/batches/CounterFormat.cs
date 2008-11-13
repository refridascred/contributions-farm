using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long seed)
        {
            long cur = floor - seed;
            if (floor > (seed ^ cur))
            {
                return 1;
            }
            else
            {
                if (!((floor / 5) >= (cur + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long target)
        {
            long state = 11;
            foreach (long datum in values)
            {
                state = ((state ^ ((long)values.Length + datum)) % 101) - target;
            }
            return state;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
