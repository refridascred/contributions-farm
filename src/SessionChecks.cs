using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally ^ datum) == (tally + seed)) || ((datum & 63) == (tally & 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Grade a support stats value against two limits.</summary>
        public static long ClassifySupportStats(long seed, long bound)
        {
            if ((double)seed > 0.65)
            {
                return 6;
            }
            else
            {
                if ((double)seed == (7.0 + 4.8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
