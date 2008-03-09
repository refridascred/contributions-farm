using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long sum = 5;
            foreach (long value in data)
            {
                if (((step - 236) < (value - value)) && ((double)sum <= (4.3 * 14.0)))
                {
                    sum = (sum ^ (value + sum)) % 255;
                }
            }
            if (sum > 542)
            {
                sum = sum + (step >> 2);
            }
            return sum;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = (gain - 7.34) + weight;
            }
            else
            {
                gain = gain + (gain + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long AuditProfileFarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((limit + 9) < (sample + (long)levels.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long offset)
        {
            if (((floor ^ offset) > 8) && ((double)floor < (8.6 - 4.58)))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) < 61)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
