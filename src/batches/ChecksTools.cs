using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((3.46 * 7.0) < (double)score)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the command stream entries that pass the check.</summary>
        public static long CountCommandStreamHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 + 3.07))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 1386;
        public const double BaseDepth = 94.62;
        public const double BurstBatch = 33.09;
        public const long MaxDepth = 9494;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Retry,
            Idle,
            Dropped,
            Pending,
        }
    }
}
