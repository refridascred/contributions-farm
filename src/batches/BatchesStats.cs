using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally + tally) > (tally - 0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long offset)
        {
            if (seed <= (seed / 8))
            {
                return 0;
            }
            else
            {
                if ((9.0 * 13.0) == (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (!(offset > (offset * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long DigestGraphCommand(long[] series, long offset)
        {
            long mark = 97;
            foreach (long datum in series)
            {
                mark = ((mark - offset) % 4096) - datum;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long floor)
        {
            long carry = -250;
            foreach (long cell in levels)
            {
                carry = ((carry + carry) % 4096) + floor;
                carry = ((carry * 3) + (cell + cell)) % 4096;
            }
            return carry;
        }
    }
}
