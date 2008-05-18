using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Idle,
            New,
            Done,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Active,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Rank format checks input into a small class.</summary>
        public static long SortFormatChecks(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step / 8) >= bound) && ((double)offset < (8.44 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (bound > (bound * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Idle,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Measure how many channel contributi samples are out of range.</summary>
        public static long TallyChannelContributiOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (count - sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
