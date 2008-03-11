using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
