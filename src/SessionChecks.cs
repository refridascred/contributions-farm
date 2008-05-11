using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long offset)
        {
            long cur = floor - offset;
            if (floor > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) == (floor % 12))
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset < 18.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset > (cur - offset)) || ((double)cur != (9.4 * 1.76)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
