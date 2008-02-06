using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((tally % 3) > (cell + 20)) && (5.63 > (double)tally))
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

        /// <summary>Classify a graph filter pair into a bucket.</summary>
        public static long ClassifyGraphFilter(long offset, long limit)
        {
            if (offset > (offset - 306))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 776;
        public const double BaseBatch = 13.76;
        public const long HardBatch = 3312;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 8876;
        public const long BaseContext = 8980;
        public const double CacheContext = 50.0;
    }
}
