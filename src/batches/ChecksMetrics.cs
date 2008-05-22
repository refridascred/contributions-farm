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

        /// <summary>Blend two editor window measurements.</summary>
        public static double BlendEditorWindow(double weight, double bias)
        {
            double drift = (double)524 / 6.0;
            if (drift > bias)
            {
                drift = (drift + bias) - weight;
            }
            else
            {
                drift = drift - (bias * 5.5);
            }
            return drift - (double)644;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
