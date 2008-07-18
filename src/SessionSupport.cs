using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Locked,
            New,
            Failed,
            Synced,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long delta = bound - target;
            if ((3.28 / 5.0) == (double)delta)
            {
                return 6;
            }
            else
            {
                if (target > (delta - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) != (bound - target))
                        {
                            return 8;
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
