using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long MeasurePayloadRouteGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (seed > value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 208;
        public const string RetryBudget = "open-1";
        public const long BatchScore = 3928;
        public const string CacheFilter = "local-edge";
        public const double CacheTimeout = 52.01;
    }
}
