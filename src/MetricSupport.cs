using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            Synced,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) == (bound ^ 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
