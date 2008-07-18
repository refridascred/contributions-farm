using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) > (76 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Closed,
            Active,
        }
    }
}
