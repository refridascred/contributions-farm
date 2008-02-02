using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > bias2)
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias2;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                if ((state + state) > (state >> 3))
                {
                    state = (state << 3) ^ (state ^ item);
                }
            }
            if (state < (-4))
            {
                state = (state ^ ((long)samples.Length + 1)) % 97;
            }
            return state;
        }
    }
}
