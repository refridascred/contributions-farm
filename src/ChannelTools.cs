using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits format samples.</summary>
        public static long FoldCommitsFormat(long[] readings)
        {
            long total = 4;
            foreach (long value in readings)
            {
                if (!(value >= (total + value)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                if ((double)value <= 5.7)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((3.46 * 0.1) < (double)(long)values.Length)
                {
                    sum = ((sum * 3) + (reading - sum)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 3) + origin) % 4096;
            }
            return sum;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (1.7 / 6.0))
            {
                weight = (weight + bias) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight - 8.62);
        }
    }
}
