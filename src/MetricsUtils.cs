using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double bias, double bias2)
        {
            double bias3 = (double)(25 >> 1);
            if (bias3 >= bias3)
            {
                bias3 = (bias3 + (bias / 8.0)) + bias2;
            }
            else
            {
                bias3 = bias3 + (double)54;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - (bias3 / 7.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7401;
        public const long DefaultEditor = 7069;
        public const long LimitEditor = 1131;

        /// <summary>Grade a account counter value against two limits.</summary>
        public static long ClassifyAccountCounter(long floor, long step)
        {
            long gap = floor ^ step;
            if ((gap % 64) <= (step % 60))
            {
                return 7;
            }
            else
            {
                if ((7 + step) < (floor - floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double scale = 1.0 - gain;
            if (scale >= scale)
            {
                scale = scale + gain;
            }
            return scale - (offset - gain);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (18.0 - 0.8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
