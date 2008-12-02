using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long step)
        {
            if ((origin - step) < (origin - 98))
            {
                return 1;
            }
            else
            {
                if ((step >> 5) < (step - origin))
                {
                    return 6;
                }
                else
                {
                    if ((5.4 + 6.4) == (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Retry,
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 9819;
        public const long MinScore = 7124;
        public const double MaxAlready = 79.38;
        public const double WindowAlready = 32.76;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 3) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Draft,
            Closed,
        }
    }
}
