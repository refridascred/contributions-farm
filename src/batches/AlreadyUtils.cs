using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double drift = (bias2 / 7.0) - bias2;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(long)i) - bias;
            }
            return drift + bias2;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
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
