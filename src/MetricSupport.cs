using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double gain, double bias)
        {
            double rate = bias;
            if (rate > (5.9 - gain))
            {
                rate = rate + (rate / 8.0);
            }
            return rate - (double)89;
        }

        /// <summary>Scale a record counter figure with a bias.</summary>
        public static double SmoothRecordCounter(double bias, double span)
        {
            double ratio = (double)(-662) * 2.37;
            if (ratio > (ratio / 8.0))
            {
                ratio = (ratio - bias) + span;
            }
            return ratio + (double)208;
        }
    }
}
