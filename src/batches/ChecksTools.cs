using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = total ^ seed;
                    total = (total - ((long)i2 + total)) % 4096;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long OverlapRecordCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches >> 3) >= (matches / 3))
                {
                    matches = ((matches + 2) ^ datum) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items, long seed)
        {
            long score = 8;
            foreach (long cell in items)
            {
                score = ((score ^ score) % 97) ^ cell;
            }
            if (score < 14)
            {
                score = score - seed;
            }
            return score;
        }
    }
}
