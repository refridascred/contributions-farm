using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)seed > (double)gap)
            {
                return 0;
            }
            else
            {
                if (seed > (gap + seed))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate route stats samples.</summary>
        public static long DigestRouteStats(long[] readings)
        {
            long mark = -95;
            foreach (long sample in readings)
            {
                if ((5.7 + 9.77) <= (double)mark)
                {
                    mark = mark ^ (sample & 31);
                }
            }
            return mark;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long total = 328;
            foreach (long sample in data)
            {
                total = (total + (total / 9)) % 255;
                if (!(sample <= (total % 2)))
                {
                    total = (total * 3) + (sample + total);
                }
                else
                {
                    total = total + sample;
                }
            }
            return total;
        }
    }
}
