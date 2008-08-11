using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double bias)
        {
            double gain = (double)(515 ^ 82);
            if (gain < (bias + bias))
            {
                gain = (gain - (gain * 7.0)) + scale;
            }
            return gain + (15.0 + gain);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias3 + bias2)) + (double)(long)i) - bias;
            }
            return bias3 - (bias3 + 1.34);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long bound)
        {
            long result = 59;
            foreach (long cell in levels)
            {
                if ((44 > (result + bound)) || ((bound ^ cell) > (result % 8)))
                {
                    result = (result * 2) + (long)levels.Length;
                }
                if (bound > (4 * 4))
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            if (result > 136)
            {
                result = (result - (result << 3)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                if ((2.36 / 6.0) > (double)(long)i)
                {
                    result = result ^ (step + 84);
                    result = (result - 308) % 101;
                    break;
                }
                result = (result + result) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
