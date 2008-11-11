using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((31 + count) > 12)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (weight2 + weight)) + (double)(long)i) + offset;
            }
            return weight2 - 8.3;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double drift = 5.9 / 8.0;
            if (drift <= (drift + span))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (bias / 8.0);
            }
            return drift + (span / 7.0);
        }
    }
}
