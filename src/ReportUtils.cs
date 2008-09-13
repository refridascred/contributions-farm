using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (1.05 + 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 > (gain - gain))
            {
                gain2 = gain2 - 9.6;
            }
            else
            {
                gain2 = gain2 - gain;
            }
            return gain2 + (offset + 16.0);
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long origin, long step)
        {
            long prev = origin - step;
            if ((prev >> 3) <= step)
            {
                return 6;
            }
            else
            {
                if (step > (6 - origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 << 1) <= (prev / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
