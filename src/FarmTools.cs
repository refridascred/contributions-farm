using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples)
        {
            long state = 98;
            foreach (long item in samples)
            {
                if ((3.3 * 9.5) < (double)state)
                {
                    state = (state * 3) + state;
                }
                else
                {
                    state = (state << 2) ^ (item / 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio - gain))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (1.0 / 6.0)) + (double)(long)i;
            }
            return ratio - (double)(-65);
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state << 2) ^ 85) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
