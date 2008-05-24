using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
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
