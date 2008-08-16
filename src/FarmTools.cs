using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + (target << 1)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (bound + (-732))) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 255) + (long)i2;
                }
                sum = (sum + sum) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double weight = offset;
            if (weight <= (weight + bias))
            {
                weight = weight - (weight / 9.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (bias / 9.0);
        }
    }
}
