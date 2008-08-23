using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long state = 15;
            foreach (long entry in series)
            {
                if ((14.0 / 6.0) == (double)state)
                {
                    state = ((state * 4) + (origin / 5)) % 255;
                }
                else
                {
                    state = (state + (entry + 256)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardBudget = "open-edge";
        public const string IdleSize = "open-v2";
        public const double CacheChannel = 30.1;
        public const long BaseSpan = 3227;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            long span = limit + bound;
            if (!((5 + limit) > (bound - span)))
            {
                return 7;
            }
            else
            {
                if (limit >= (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (span <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
