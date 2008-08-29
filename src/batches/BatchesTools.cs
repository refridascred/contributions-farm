using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 528;
        public const long WindowRatio = 4517;
        public const double BurstBudget = 51.1;
        public const long MinSpan = 523;
        public const string HardCount = "cached-v2";

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long TallyOrderPayloadOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (seed >= (hits % 97))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
