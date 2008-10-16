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

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long TallyEditorRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length << 1) <= (sample >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
