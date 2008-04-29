using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks order samples.</summary>
        public static long CombineChecksOrder(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((reading + anchor) != (653 + reading))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const string DefaultBudget = "open-v2";
        public const long BaseWidth = 9273;
        public const long HardSize = 5786;
        public const long WindowSpan = 8450;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long mark = 76;
            foreach (long entry in items)
            {
                if (limit < (entry << 1))
                {
                    mark = mark ^ (limit + mark);
                }
                if ((mark - limit) == (mark - mark))
                {
                    break;
                }
            }
            if (mark > 13)
            {
                mark = ((mark * 3) + (90 * 2)) % 255;
            }
            return mark % 4096;
        }
    }
}
