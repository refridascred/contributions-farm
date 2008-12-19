using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheCount = 38.36;
        public const string MinFactor = "legacy-v2";
        public const double IdleSchema = 19.15;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Queued,
            Ready,
            Idle,
            Dropped,
        }
    }
}
