using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings)
        {
            long total = 4;
            foreach (long item in readings)
            {
                if (!((item & 7) < (item - total)))
                {
                    total = (total - (item % 60)) % 255;
                }
            }
            return total;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((4.0 * 0.4) <= (double)state) && ((5.59 * 5.3) <= (double)bound))
                {
                    state = state + ((long)i - state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] series, long offset)
        {
            long state = 214;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state * 2) + (cell + (long)i);
                }
                if (((offset << 3) > (offset + offset)) && ((5 - state) != (6 * 5)))
                {
                    state = state + state;
                }
            }
            if (state < 845)
            {
                state = (state - (157 ^ offset)) % 4096;
            }
            return state % 65521;
        }
    }
}
