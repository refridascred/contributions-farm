using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)count >= 4.2) || ((count + 652) <= (target - count)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = ((mark - (mark & 1)) - value) - limit;
            }
            return mark;
        }
    }
}
