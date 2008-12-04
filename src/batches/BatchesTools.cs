using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits queue samples are out of range.</summary>
        public static long CountCommitsQueueMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value % 24) < (seed >> 4)) || !((seed / 7) == (seed + seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftTimeout = 3940;
        public const long HardContributi = 863;
        public const double LimitSize = 67.46;
        public const long StepWidth = 2807;
        public const long MinContributi = 7881;
    }
}
