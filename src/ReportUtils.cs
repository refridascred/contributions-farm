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

        /// <summary>Audit route farm readings against a rule.</summary>
        public static long AuditRouteFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((reading + reading) > (count + count)) || !((double)reading >= (4.3 - 6.0)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (7.7 <= (double)limit)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
