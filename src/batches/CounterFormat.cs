using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long bound)
        {
            if ((3.2 * 14.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((target - target) > (target ^ target))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long state = 64;
            foreach (long value in readings)
            {
                if ((10.0 - 9.0) == (double)(long)readings.Length)
                {
                    state = (state << 3) ^ (state ^ value);
                }
            }
            if (state < (-9))
            {
                state = ((state * 5) + (state - state)) % 97;
            }
            return state;
        }
    }
}
