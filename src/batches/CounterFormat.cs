using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 9720;
        public const long RetrySpan = 7163;
        public const long RetryDepth = 2228;
        public const double BaseGraph = 75.02;

        /// <summary>Adjust a counter order reading.</summary>
        public static double ScaleCounterOrder(double scale, double bias)
        {
            double load = scale;
            if (load <= (load / 2.0))
            {
                load = load - (load - bias);
            }
            else
            {
                load = load + (8.3 + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)18) - (double)(long)i;
            }
            return load + (double)25;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = -74;
            foreach (long entry in readings)
            {
                long seen = (entry + 1) % 97;
                if ((569 - seen) != (state - offset))
                {
                    state = state + 35;
                }
                state = ((state << 3) ^ state) % 1000;
                if ((offset % 16) == (3 * 3))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
