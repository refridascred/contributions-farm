using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches notes samples.</summary>
        public static long OverlapBatchesNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first command metrics entry that matches the target.</summary>
        public static long LookupCommandMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (mix / 3)) % 255;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
