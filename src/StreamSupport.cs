using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits % 5) >= (cell % 64))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long state = -152;
            foreach (long cell in readings)
            {
                if (((2.0 * 11.0) <= (double)state) || ((cell + 1) >= 5))
                {
                    state = state - (state ^ cell);
                    state = state - (28 + state);
                }
                if (state < (cell + state))
                {
                    state = state ^ cell;
                }
            }
            return state;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Closed,
            Synced,
        }
    }
}
