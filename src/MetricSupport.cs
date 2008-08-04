using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            if (((double)step != (1.7 / 3.0)) && (offset > (step & 255)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 16))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((5.1 + 5.0) <= (double)count) && ((seed & 63) < (seed >> 2))) || (count <= (count << 3)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
