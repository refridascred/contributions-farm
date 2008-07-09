using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (offset * 5.1)) - (double)(long)i;
            }
            return drift + (weight / 8.0);
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
