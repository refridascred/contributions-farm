using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowLevel = "stable-edge";
        public const long IdleTimeout = 5207;
        public const double MinSize = 78.59;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                if (((5 + acc) == (acc - entry)) || ((entry % 24) >= (entry >> 4)))
                {
                    acc = (acc - (entry ^ 1)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already contributi samples are out of range.</summary>
        public static long TallyAlreadyContributiOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)origin != (double)matches) || ((899 * 2) != (matches * 3)))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
