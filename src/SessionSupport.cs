using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up report stats samples.</summary>
        public static long OverlapReportStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((((long)series.Length - item) < (799 + item)) && ((double)matches >= 13.0)) && (step <= (item >> 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((7 & 1) == (seed + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
