using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((10.0 + 6.46) == (double)(long)i))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two entry queue measurements.</summary>
        public static double ScaleEntryQueue(double ratio, double offset)
        {
            double bias = (offset + ratio) * 11.0;
            if (bias <= (bias * 9.3))
            {
                bias = bias - (double)85;
            }
            else
            {
                bias = bias + (offset * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
