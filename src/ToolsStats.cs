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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long AuditBatchContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (tally >> 2))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
