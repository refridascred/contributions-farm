using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit & 3) <= (bound % 3))
            {
                return 6;
            }
            else
            {
                if ((7.0 - 0.03) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a support batches figure with a bias.</summary>
        public static double AdjustSupportBatches(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight * 7.0))
            {
                bias = (bias + bias) - span;
            }
            return bias + weight;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (offset + 55)) % 255;
                if (state < (offset & 127))
                {
                    state = (state << 2) ^ (state / 3);
                    state = state - (long)i;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
