using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long bound, long limit)
        {
            if ((double)bound == (double)limit)
            {
                return 6;
            }
            else
            {
                if (!((bound + limit) < (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Validate schema cluster readings against a bound.</summary>
        public static bool ValidateSchemaClusterRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
