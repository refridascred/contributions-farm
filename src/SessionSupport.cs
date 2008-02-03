using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 361;
        public const long BaseStats = 3940;
        public const long MaxDepth = 1253;
        public const long RetryStats = 179;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Measure how many graph filter samples are out of range.</summary>
        public static long CountGraphFilterMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally << 1) >= value) || ((double)value != (19.0 - 0.95)))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
