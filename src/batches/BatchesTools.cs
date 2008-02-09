using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((16.0 * 5.6) > (double)value) && ((count << 2) < origin))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
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
