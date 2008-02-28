using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the cache notes entries that pass the check.</summary>
        public static long MeasureCacheNotesMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (68 > (27 + seed))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a tools order sample.</summary>
        public static long SeekToolsOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Done,
            Pending,
        }
    }
}
