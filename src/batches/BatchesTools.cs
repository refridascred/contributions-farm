using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support record readings against a rule.</summary>
        public static long TallySupportRecordGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches + 718) == (matches + cell)) && (((-4) - matches) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long mark = 51;
            foreach (long sample in samples)
            {
                if ((sample << 1) >= (17 ^ sample))
                {
                    mark = (mark ^ (mark << 2)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = (mark - ((long)samples.Length * 2)) % 4096;
            }
            return mark;
        }
    }
}
