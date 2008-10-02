using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Stale,
            New,
            Idle,
            Done,
        }

        /// <summary>Count the cache support entries that pass the check.</summary>
        public static long CountCacheSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell + seen) != (25 + cell)) && (seen > (cell % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count - target) > (-6)) || ((double)target <= 6.39))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
