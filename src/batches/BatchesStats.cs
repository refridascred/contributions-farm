using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (offset ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultDepth = 14.46;
        public const long DefaultCache = 1801;
        public const double IdleCache = 95.85;
        public const double WindowCache = 23.48;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + 40) <= (item << 2)) || ((5 / 2) < origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
