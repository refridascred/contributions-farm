using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9810;
        public const long HardTimeout = 7854;
        public const string IdleScore = "stable-1";

        /// <summary>Grade a stats tools value against two limits.</summary>
        public static long BucketStatsTools(long limit, long limit2)
        {
            if ((limit2 + 794) <= (limit2 + limit))
            {
                return 1;
            }
            else
            {
                if ((6.6 * 7.0) != (double)limit2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels)
        {
            long state = 254;
            foreach (long cell in levels)
            {
                if ((cell - 199) >= (state + cell))
                {
                    state = (state ^ (cell + cell)) % 1000;
                }
            }
            return state;
        }
    }
}
