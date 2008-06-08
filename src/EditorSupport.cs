using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Locked,
            New,
            Synced,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 3450;
        public const long BurstWindow = 9635;
        public const long CacheInterval = 7490;
        public const long DefaultInterval = 4825;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Pending,
            Active,
            Retry,
        }
    }
}
