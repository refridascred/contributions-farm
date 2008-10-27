using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (floor - ratio) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio / 4.0)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Draft,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 16) > (1 * 2))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
