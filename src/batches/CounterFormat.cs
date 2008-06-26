using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double weight = gain;
            if (weight <= (double)3)
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + 6.0;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = state - 25;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state - target) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
