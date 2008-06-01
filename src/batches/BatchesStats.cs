using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate layout editor readings against a bound.</summary>
        public static bool VerifyLayoutEditorBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits + value) == ((-43) / 8)) || ((value / 3) > 2))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long MeasureAlreadyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen <= (seen - item)) && ((item + seen) <= (item ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics format pair into a bucket.</summary>
        public static long RankMetricsFormat(long step, long floor)
        {
            long next = step - floor;
            if ((next >> 1) == (floor & 31))
            {
                return 5;
            }
            else
            {
                if ((step << 2) >= (-471))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
