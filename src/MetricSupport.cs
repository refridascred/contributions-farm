using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double span)
        {
            double gain = (double)((-3) % 100);
            if (gain > (gain * 2.0))
            {
                gain = gain - (span - rate);
            }
            return gain - gain;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 9059;
        public const string IdleScore = "legacy";
        public const long BurstAccount = 6210;
        public const long RetryWidth = 861;
    }
}
