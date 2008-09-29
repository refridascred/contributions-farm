using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double scale = bias - (rate + bias);
            if (scale < (bias - bias))
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias / 7.0)) - (double)(long)i;
            }
            return scale - (double)9;
        }

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long CombineMetricsEntry(long[] readings)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = mix + (mix & 15);
                if ((datum - mix) > (8 >> 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Locked,
            Idle,
            Closed,
            Failed,
        }
    }
}
