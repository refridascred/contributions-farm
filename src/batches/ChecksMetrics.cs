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

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long origin)
        {
            long next = floor + origin;
            if ((floor ^ floor) >= 32)
            {
                return 7;
            }
            else
            {
                if (((double)84 < (double)floor) || ((floor ^ next) == (next * 4)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (8.1 > (double)floor)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
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
