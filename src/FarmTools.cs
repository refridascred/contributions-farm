using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((total <= seed) || (total >= (total << 2)))
                {
                    total = total - ((long)i >> 2);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
