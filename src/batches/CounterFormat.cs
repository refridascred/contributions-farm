using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long sum = 23;
            foreach (long reading in levels)
            {
                if ((sum + reading) != (sum << 2))
                {
                    sum = (sum ^ (reading >> 2)) % 4096;
                }
                if (((sum - reading) != (reading - 19)) && (reading > (sum << 1)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long TallyFormatCacheHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)offset > (3.0 + 2.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 3) >= 416)
                {
                    count = ((count + 3) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
