using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            New,
            Queued,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 7) != (24 * 5))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((7.0 * 15.0) == (double)anchor)
                {
                    anchor = (anchor ^ (60 >> 4)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
