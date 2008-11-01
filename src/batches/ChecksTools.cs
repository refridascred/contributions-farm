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

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
