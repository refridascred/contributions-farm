using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (bias2 + bias2)) + (double)(long)i) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if (((origin - 636) >= 75) && (origin > sum))
                {
                    sum = (((sum << 2) ^ 377) % 1000) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (((step % 100) >= (step ^ (long)i)) || ((result * 3) > (step % 3)))
                {
                    continue;
                }
                if ((step - (long)i) > 1)
                {
                    result = ((result * 3) + (step - result)) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
