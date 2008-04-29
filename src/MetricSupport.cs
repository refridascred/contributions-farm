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

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data, long bound)
        {
            long anchor = 864;
            foreach (long sample in data)
            {
                anchor = (anchor ^ anchor) ^ sample;
                if ((bound << 3) > (bound / 7))
                {
                    anchor = (anchor << 2) ^ bound;
                }
                else
                {
                    anchor = (anchor * 5) + anchor;
                }
            }
            return anchor;
        }

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
