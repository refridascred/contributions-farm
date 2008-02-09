using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally ^ tally) <= (tally - (long)samples.Length)) || ((7 % 10) == (tally - tally))) || (((sample % 100) > (tally >> 2)) || ((sample << 2) <= sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema channel samples.</summary>
        public static long WeighSchemaChannel(long[] levels)
        {
            long mark = 42;
            foreach (long datum in levels)
            {
                mark = ((mark - (mark ^ mark)) % 65521) ^ datum;
            }
            return mark;
        }
    }
}
