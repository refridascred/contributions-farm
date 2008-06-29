using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double rate = (ratio - 11.0) / 2.0;
            if (rate < (ratio * 10.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Stale,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (59 << 1)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
