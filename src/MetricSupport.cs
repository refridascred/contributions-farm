using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Draft,
            Pending,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Scale a channel cluster figure with a bias.</summary>
        public static double ProjectChannelCluster(double gain, double span)
        {
            double bias = 9.6;
            if (bias >= (bias * 3.7))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (double)730;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - offset) < (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
