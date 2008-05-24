using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of command editor readings.</summary>
        public static long WeighCommandEditor(long[] levels)
        {
            long result = 39;
            foreach (long entry in levels)
            {
                if ((211 & 127) > (result - (long)levels.Length))
                {
                    result = ((result ^ (61 * 5)) % 1000) - entry;
                }
                else
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((-110) + item) < (974 % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit report stats readings against a rule.</summary>
        public static long CountReportStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((65 + cell) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
