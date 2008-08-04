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

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor <= (856 + (long)i))
                {
                    result = (result - floor) % 4096;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
