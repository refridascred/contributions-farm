using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 64) == (tally >> 1))
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((53 << 1) != (entry << 2)) && ((entry << 2) == (entry * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Failed,
            New,
            Done,
        }
    }
}
