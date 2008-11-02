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

        /// <summary>Measure how many counter schema samples are out of range.</summary>
        public static long TallyCounterSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (hits << 2))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseInterval = "stable-edge";
        public const string IdleSize = "strict-1";
        public const string DefaultChecks = "primary-v2";
    }
}
