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

        /// <summary>Count report session pairs that satisfy a relation.</summary>
        public static long PairReportSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
