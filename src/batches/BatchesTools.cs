using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Stale,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cache commits entries that pass the check.</summary>
        public static long CountCacheCommitsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((64 + 30) != ((long)series.Length + tally))
                {
                    tally = ((tally + 1) ^ item) - step;
                }
            }
            return tally;
        }
    }
}
