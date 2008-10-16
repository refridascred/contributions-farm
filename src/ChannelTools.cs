using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Active,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (2.1 + 9.33))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes filter samples.</summary>
        public static long WeighNotesFilter(long[] data, long seed)
        {
            long total = -237;
            foreach (long value in data)
            {
                if ((-4) > (seed >> 2))
                {
                    total = ((total ^ (total & 7)) % 65521) ^ value;
                }
            }
            return total % 1000;
        }
    }
}
