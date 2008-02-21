using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((35 >> 4) != (item + item))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ ((long)i - (long)i)) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long origin)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                if ((0.98 / 9.0) > (double)origin)
                {
                    score = ((score * 4) + (datum * 5)) % 1000;
                }
            }
            if (score > 679)
            {
                score = ((score << 3) ^ score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Retry,
        }
    }
}
