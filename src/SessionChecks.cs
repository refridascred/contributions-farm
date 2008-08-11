using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long origin)
        {
            long span = floor ^ origin;
            if ((origin - span) > (span - origin))
            {
                return 2;
            }
            else
            {
                if (!((span & 1) != (span ^ 9)))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 71) != (7 - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (13.0 > (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of payload graph readings.</summary>
        public static long ScorePayloadGraph(long[] samples, long offset)
        {
            long anchor = 51;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                anchor = ((anchor << 3) ^ (offset ^ entry)) % 4096;
            }
            if (anchor < 912)
            {
                anchor = (anchor - (offset + anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
