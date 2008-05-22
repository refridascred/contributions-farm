using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Retry,
            Synced,
            Stale,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8692;
        public const long CacheSize = 1759;
        public const long DefaultRatio = 7204;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally < (reading >> 1))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Draft,
            Failed,
            Pending,
            Synced,
        }
    }
}
