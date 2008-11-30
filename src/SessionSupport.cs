using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches % 12) > (sample % 5))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
