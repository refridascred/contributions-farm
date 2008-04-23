using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Paused,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long bound, long target)
        {
            long diff = bound - target;
            if (((bound + bound) >= (bound + target)) && (diff >= bound))
            {
                return 7;
            }
            else
            {
                if ((bound > (diff << 3)) && ((8 * 5) >= diff))
                {
                    return 8;
                }
                else
                {
                    if (!((double)target >= (2.45 - 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.54 + 3.4) < (double)diff)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
