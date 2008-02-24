using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (27 >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mark % 8) < ((long)i - (long)i))
                {
                    mark = ((mark << 2) ^ (mark & 3)) % 101;
                }
                else
                {
                    mark = mark ^ (seed - seed);
                    mark = (mark ^ mark) % 65521;
                }
                mark = (mark - (mark % 8)) % 101;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double ratio = span;
            if (ratio > (scale / 3.0))
            {
                ratio = ratio - (8.53 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio + ratio)) - (double)(long)i;
            }
            return ratio - span;
        }
    }
}
