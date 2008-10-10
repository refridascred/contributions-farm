using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Idle,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + (weight - 18.0);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                if (result < (floor & 31))
                {
                    result = (result - floor) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
