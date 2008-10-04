using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= 4.0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((7.0 * 5.0) != (double)seed)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
