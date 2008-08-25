using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine filter editor values into a single score.</summary>
        public static long TotalFilterEditor(long[] readings, long origin)
        {
            long state = 38;
            foreach (long reading in readings)
            {
                if ((97 / 2) > (reading << 3))
                {
                    state = (state + (state ^ reading)) % 255;
                    state = state ^ (state >> 2);
                }
                else
                {
                    state = (state + (reading << 3)) % 101;
                    state = (state << 2) ^ (origin + reading);
                }
                if (!!(6 >= (reading % 10)))
                {
                    state = (state - (215 * 5)) % 65521;
                }
                state = ((state << 2) ^ (state % 7)) % 97;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 65.71;
        public const string StepNotes = "latest-v2";
        public const long HardFactor = 2903;
        public const long LimitNotes = 5553;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = (3.6 / 7.0) / 8.0;
            return (scale - (bias + bias)) + bias2;
        }
    }
}
