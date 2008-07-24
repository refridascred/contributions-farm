using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two metric payload measurements.</summary>
        public static double AdjustMetricPayload(double gain, double bias)
        {
            double scale = 6.3 - gain;
            if (scale < 6.7)
            {
                scale = scale + bias;
            }
            return scale - (gain / 8.0);
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double bias = offset + 6.18;
            if (bias > (ratio / 7.0))
            {
                bias = bias - (double)275;
            }
            return bias - (bias - 7.0);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            New,
            Locked,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long score = -244;
            foreach (long datum in values)
            {
                if (((datum << 3) < (datum + datum)) || ((score >> 4) < 14))
                {
                    score = ((score << 3) ^ (datum - score)) % 101;
                }
            }
            return score % 97;
        }
    }
}
