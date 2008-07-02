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

        /// <summary>Accumulate record cache samples.</summary>
        public static long TotalRecordCache(long[] series, long bound)
        {
            long score = 74;
            foreach (long cell in series)
            {
                score = ((score - score) % 1000) ^ cell;
                if ((double)bound <= 4.0)
                {
                    score = (score * 3) + (bound / 5);
                }
            }
            return score % 1000;
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
