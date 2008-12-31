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

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long origin)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = (mark * 5) + (origin % 12);
                if ((((long)data.Length & 7) >= origin) && ((origin << 3) <= (entry - entry)))
                {
                    mark = mark ^ (mark * 5);
                }
            }
            return mark;
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
