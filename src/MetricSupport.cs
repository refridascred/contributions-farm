using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 7324;
        public const long BatchBatches = 1756;
        public const long DefaultBatches = 2861;
        public const long BurstWidth = 8434;
        public const long LimitCount = 2486;

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double drift = (double)50 / 8.0;
            if (drift > weight)
            {
                drift = (drift + weight) - span;
            }
            else
            {
                drift = drift - (double)14;
            }
            return drift + (drift - weight);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long anchor = 564;
            foreach (long value in samples)
            {
                if ((2.8 <= (double)value) && ((2 >> 5) >= anchor))
                {
                    anchor = anchor - (value & 3);
                }
            }
            return anchor;
        }
    }
}
