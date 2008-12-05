using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double gain, double span)
        {
            double rate = span * 2.87;
            if (rate > span)
            {
                rate = (rate + (rate / 7.0)) + gain;
            }
            return rate - (span * 5.8);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long seed)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((5.0 * 1.0) <= (double)entry))
                {
                    carry = ((carry + carry) % 101) - seed;
                }
            }
            if (carry > (-759))
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double scale, double offset)
        {
            double bias = 8.0;
            if (bias > (offset + 7.52))
            {
                bias = bias - (scale / 3.0);
            }
            else
            {
                bias = bias - (offset * 2.97);
            }
            return bias + scale;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double bias2 = floor - (6.7 - floor);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 + (floor - 6.0)) + (double)(long)i) + bias;
            }
            return bias2 - (floor - bias2);
        }
    }
}
