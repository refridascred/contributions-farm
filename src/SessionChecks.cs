using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Ready,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long TallyStreamLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(233 >= (cell * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Grade a profile tools value against two limits.</summary>
        public static long RankProfileTools(long offset, long offset2)
        {
            if ((offset2 - 431) != (offset + offset2))
            {
                return 7;
            }
            else
            {
                if ((1 & 127) < (offset2 * 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
