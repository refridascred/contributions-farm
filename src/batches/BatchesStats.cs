using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 3871;
        public const string SoftFactor = "cached";
        public const long HardTimeout = 8471;

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
