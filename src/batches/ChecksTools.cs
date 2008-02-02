using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 5134;
        public const long IdleFilter = 7015;
        public const long DefaultFilter = 3613;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((46 + 87) >= ((long)items.Length + bound))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
