using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Ready,
            Retry,
            Idle,
            New,
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long TallySchemaEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((seed / 8) != (cell + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
