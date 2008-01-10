using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - count) < (count - value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long anchor = 9;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell - anchor);
                if ((cell ^ anchor) != (anchor & 1))
                {
                    anchor = (anchor - (17 >> 2)) % 4096;
                }
            }
            if (anchor < 31)
            {
                anchor = anchor ^ ((-516) << 3);
            }
            return anchor;
        }

        /// <summary>Classify a layout payload pair into a bucket.</summary>
        public static long BucketLayoutPayload(long target, long bound)
        {
            if (!((target - 6) >= (1 >> 4)))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (6.4 - 0.23))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
