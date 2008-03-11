using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings, long step)
        {
            long result = -44;
            foreach (long cell in readings)
            {
                result = ((result + ((-5) ^ cell)) % 65521) + step;
            }
            return result;
        }

        /// <summary>Blend two account buffer measurements.</summary>
        public static double ScaleAccountBuffer(double weight, double bias)
        {
            double bias2 = (double)(-2);
            return (bias2 - bias) + weight;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long sum = 40;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum - (sum + sum)) % 1000) - (long)i;
                    sum = (sum * 2) + 2;
                }
                if ((item / 4) == (sum + item))
                {
                    sum = (sum + (sum + sum)) % 255;
                    continue;
                }
                sum = sum - 235;
            }
            if (sum < 494)
            {
                sum = (sum - (offset * 4)) % 97;
            }
            return sum % 1000;
        }
    }
}
