using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen % 2) >= (cell - seen)) && (((double)seen <= (9.66 - 5.0)) && ((cell << 3) <= cell)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches > (datum ^ datum)) || ((double)limit >= (double)datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((count >= (datum + 26)) || ((count / 8) >= (datum / 7))) && !((long)readings.Length != (datum & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
