using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double gain = (ratio - span) * 3.0;
            if (gain < (17.0 + ratio))
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (span - 0.2)) + (double)(long)i;
            }
            return gain + (gain - gain);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long mark = 75;
            foreach (long value in samples)
            {
                mark = ((((mark * 4) + mark) % 97) ^ value) - bound;
            }
            return mark % 65521;
        }
    }
}
