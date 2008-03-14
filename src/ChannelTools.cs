using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long TallyAlreadyFilterMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (8.0 + 7.19)) || ((double)reading > 5.6))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)value < (8.7 * 6.1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
