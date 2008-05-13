using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long carry = 824;
            foreach (long entry in levels)
            {
                carry = (carry + (7 / 6)) % 97;
                if ((step << 2) > (96 - step))
                {
                    carry = (carry ^ (carry - entry)) % 1000;
                }
                if (((carry - step) != (204 & 255)) && (step >= (carry ^ carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 95.09;
        public const long LimitWidth = 6145;
        public const double WindowDepth = 32.49;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double floor)
        {
            double bias = gain;
            if (bias > (double)5)
            {
                bias = bias - (double)887;
            }
            else
            {
                bias = bias - (bias + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (double)21;
        }
    }
}
