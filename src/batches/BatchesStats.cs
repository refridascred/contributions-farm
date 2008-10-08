using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile farm entries that pass the check.</summary>
        public static long CountProfileFarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) == (target & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 786;
        public const long CacheFactor = 4066;
        public const long CacheSpan = 9435;
        public const long StepWidth = 8210;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((0 >> 4) <= (floor - step))
            {
                return 2;
            }
            else
            {
                if (75 <= (step >> 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally >= (reading << 2))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
