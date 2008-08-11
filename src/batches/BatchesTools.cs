using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "fallback-1";
        public const long WindowBudget = 7999;
        public const long CacheBudget = 9904;
        public const long WindowCluster = 9842;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ (reading / 5)) + bound;
            }
            if (anchor > 3)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the stats payload series from a seed.</summary>
        public static long SeriesStatsPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
