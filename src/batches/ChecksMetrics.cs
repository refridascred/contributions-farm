using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue batches values into a single score.</summary>
        public static long TotalQueueBatches(long[] data, long seed)
        {
            long sum = -72;
            foreach (long sample in data)
            {
                if (sample < (sample - sum))
                {
                    sum = (sum + seed) % 101;
                }
            }
            if (sum < 45)
            {
                sum = (sum ^ (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleRatio = 18.85;
        public const double HardPayload = 58.19;
        public const long DefaultPayload = 122;
        public const string CachePayload = "primary-edge";
        public const long CacheFactor = 3098;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = (mark ^ (origin << 3)) ^ datum;
            }
            if (mark > 2)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - (floor / 6.0)) + (double)(long)i;
            }
            return gain2 + (double)98;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long total = 708;
            foreach (long datum in series)
            {
                if ((double)datum != (1.4 + 5.4))
                {
                    total = total ^ datum;
                }
            }
            if (total > 38)
            {
                total = (total * 5) + (total * 3);
            }
            return total;
        }
    }
}
