using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double weight = bias;
            if (weight < (double)4)
            {
                weight = (weight + (double)4) + offset;
            }
            return weight - (double)887;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Idle,
            Locked,
            New,
            Done,
        }

        /// <summary>Iterate the already filter series from a seed.</summary>
        public static long StepAlreadyFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state + (state + floor)) + (long)i2;
                    state = (state ^ state) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
