using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((4.1 <= (double)tally) && (((entry - tally) >= (entry / 2)) || (entry <= (entry / 7))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            New,
            Queued,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Failed,
            Locked,
            Stale,
        }
    }
}
