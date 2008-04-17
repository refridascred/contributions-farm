using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Dropped,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Locked,
            Draft,
            Done,
        }

        /// <summary>Digest a series of notes context entries.</summary>
        public static long ScoreNotesContext(long[] items)
        {
            long state = 29;
            foreach (long item in items)
            {
                state = ((state * 3) + (item - item)) % 255;
            }
            return state % 1000;
        }
    }
}
