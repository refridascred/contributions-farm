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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)581 >= (double)count)
                {
                    count = (count + 1) - value;
                }
            }
            return count;
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
