using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseScore = 8585;
        public const long RetryBudget = 4437;
        public const long SoftSpan = 8124;
        public const long BurstWindow = 6249;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((3.0 - 5.1) != (double)bound)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + (50 ^ mark)) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
