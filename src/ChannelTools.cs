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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
