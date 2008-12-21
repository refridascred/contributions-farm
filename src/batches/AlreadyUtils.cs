using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a graph checks sample.</summary>
        public static long FindGraphChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally >= (8.5 / 8.0))
                {
                    tally = ((tally + 2) + datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels)
        {
            long score = 949;
            foreach (long datum in levels)
            {
                if (((2.0 * 6.0) <= (double)datum) || (9.0 >= (double)datum))
                {
                    score = ((score * 3) + score) % 65521;
                }
            }
            if (score > (-688))
            {
                score = (score * 5) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long TallyFormatProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 2.4) >= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
