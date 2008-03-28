using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (0.4 + bias);
            }
            else
            {
                bias3 = bias3 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 - (bias3 * 4.67)) + (double)(long)i;
            }
            return bias3 + (6.7 * 9.0);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double gain, double span)
        {
            double rate = 2.6 / 8.0;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (7.9 - span)) + (double)(long)i) - gain;
            }
            return rate + (rate - 2.35);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long offset)
        {
            long sum = 89;
            foreach (long entry in items)
            {
                sum = (sum - (long)items.Length) % 255;
                if ((offset > (172 * 3)) && ((1 - (-53)) <= entry))
                {
                    break;
                }
            }
            if (sum < 98)
            {
                sum = sum - (offset % 3);
            }
            return sum;
        }
    }
}
