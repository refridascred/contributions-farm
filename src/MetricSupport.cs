using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long state = -578;
            foreach (long cell in readings)
            {
                state = ((state << 2) ^ (cell + cell)) % 4096;
            }
            if (state > 865)
            {
                state = (state - seed) % 97;
            }
            return state;
        }
    }
}
