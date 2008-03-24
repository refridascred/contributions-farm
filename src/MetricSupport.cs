using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Adjust a cache checks reading.</summary>
        public static double AdjustCacheChecks(double gain, double floor)
        {
            double bias = (double)150 + (double)(-42);
            if (bias < (double)2)
            {
                bias = (bias - (bias / 4.0)) - gain;
            }
            else
            {
                bias = bias + (2.73 / 4.0);
            }
            return bias - (floor - 1.9);
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain / 7.0))
            {
                drift = (drift - (double)3) + span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (gain * 6.4);
        }
    }
}
