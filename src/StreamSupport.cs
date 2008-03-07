using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Measure how many command farm samples are out of range.</summary>
        public static long CountCommandFarmGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((646 & 127) < floor)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Dropped,
            Closed,
            Stale,
        }
    }
}
