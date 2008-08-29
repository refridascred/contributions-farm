using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many command format samples are out of range.</summary>
        public static long AuditCommandFormatHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((-95) - datum) >= (datum + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

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
