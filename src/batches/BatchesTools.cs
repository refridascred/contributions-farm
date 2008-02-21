using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double gain = (double)1;
            if (gain <= (1.0 / 8.0))
            {
                gain = (gain + (double)962) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 224;
            foreach (long value in values)
            {
                if (((34 & 7) > (state & 255)) || ((state ^ 7) < (636 - state)))
                {
                    state = (state ^ (value >> 2)) % 255;
                }
                else
                {
                    state = (state + 2) % 1000;
                }
            }
            if (state > 66)
            {
                state = ((state << 2) ^ (138 + state)) % 4096;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstInterval = 5249;
        public const long BurstSize = 1404;
        public const double MinDepth = 31.61;
    }
}
