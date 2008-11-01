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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally ^ 4) != (tally + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (517 >= origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
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
