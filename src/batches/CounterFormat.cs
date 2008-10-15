using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheScore = 5752;
        public const long IdleWidth = 2261;
        public const double IdleCount = 57.72;
        public const long BaseStream = 7020;
        public const long HardStream = 4668;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (bias - bias2))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias2 * 6.0);
        }
    }
}
