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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
