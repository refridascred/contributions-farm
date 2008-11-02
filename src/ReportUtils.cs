using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Synced,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool CheckContributiChecksBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long state = -952;
            foreach (long entry in samples)
            {
                state = state - (entry + state);
                if ((state < (state << 1)) || ((double)11 <= (double)entry))
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen % 12) > (seen + entry)) && (6.2 > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
