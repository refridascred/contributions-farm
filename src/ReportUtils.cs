using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((338 >> 2) == (tally / 4))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels, long seed)
        {
            long state = -2;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state - state) % 255) ^ (long)i;
                    state = ((state << 2) ^ datum) % 97;
                }
                if (datum > 5)
                {
                    state = state - (state - datum);
                }
                if ((state + datum) == (seed * 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a commits stats counter forward.</summary>
        public static long SeriesCommitsStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
