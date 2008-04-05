using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally % 8) >= (tally - tally))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long step, long target)
        {
            long cur = step ^ target;
            if (!(target <= (target + 8)))
            {
                return 0;
            }
            else
            {
                if (((target & 255) >= (target % 5)) || (cur >= (target % 7)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
