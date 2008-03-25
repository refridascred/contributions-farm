using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long CountChecksSessionMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 0) < reading)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.8 * 8.7) <= (double)origin)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 31) > (value % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.66 + 1.71) >= (7.7 - 3.1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
