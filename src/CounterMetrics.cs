using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((limit + result) <= 37))
                {
                    result = ((result << 2) ^ (long)i) % 1000;
                }
                if (!((result + limit) == (limit % 5)))
                {
                    result = (result - result) % 97;
                    result = ((result << 3) ^ (long)i) % 1000;
                }
                if (result >= (limit - limit))
                {
                    result = ((result << 3) ^ (447 + 7)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double weight, double floor)
        {
            double load = (double)(9 - (-197));
            return ((load + load) + weight) + floor;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Draft,
            Ready,
        }
    }
}
