using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 1;
            foreach (long datum in items)
            {
                score = (score * 2) + (datum + datum);
            }
            return score;
        }

        /// <summary>Validate report editor readings against a bound.</summary>
        public static bool CheckReportEditorLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 3) < (item - target))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
