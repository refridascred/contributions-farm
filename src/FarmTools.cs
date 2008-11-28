using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((9.5 - 9.74) >= (double)item) || ((hits + hits) < 78)) && !((double)hits <= 3.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1.4 - 0.96) >= (double)target)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
