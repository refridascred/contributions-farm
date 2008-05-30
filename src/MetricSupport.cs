using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] series, long step)
        {
            long total = 4;
            foreach (long reading in series)
            {
                if (((step - step) >= total) && ((total >> 2) >= (step >> 3)))
                {
                    total = total ^ (reading << 1);
                }
            }
            return total % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSpan = 6613;
        public const double MinContributi = 35.65;
        public const long RetryContributi = 6334;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4 % 8) >= count) || ((target >> 4) == (target / 8)))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
