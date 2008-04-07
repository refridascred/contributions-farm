using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > hits)
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
    }
}
