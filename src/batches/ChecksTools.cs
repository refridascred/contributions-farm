using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            if ((4.09 * 9.54) == (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) > (step ^ 0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Synced,
            Failed,
            Pending,
        }
    }
}
