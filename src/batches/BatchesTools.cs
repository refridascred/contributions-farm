using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many command tools samples are out of range.</summary>
        public static long TallyCommandToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (3.84 * 0.37))
                {
                    seen = ((seen + 1) + item) + seed;
                }
            }
            return seen;
        }
    }
}
