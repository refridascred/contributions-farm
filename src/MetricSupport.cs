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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample + state))
                {
                    state = (state - (sample ^ 201)) % 255;
                }
            }
            return state;
        }
    }
}
