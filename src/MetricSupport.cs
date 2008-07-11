using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)floor <= 7.54)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((281 - value) < (value << 1)) && (matches > value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long result = 92;
            foreach (long datum in items)
            {
                result = (result - (floor * 4)) ^ datum;
            }
            return result % 65521;
        }
    }
}
