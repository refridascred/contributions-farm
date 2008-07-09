using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Find the first metrics already entry that matches the target.</summary>
        public static long LocateMetricsAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item > (matches + 467))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits == (8.35 - 5.0))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
