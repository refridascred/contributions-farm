using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long MeasureChecksEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + item) < (3 + 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}
