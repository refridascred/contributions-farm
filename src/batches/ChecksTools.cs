using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double span)
        {
            double rate = (double)(91 - 6);
            if (rate > (rate - span))
            {
                rate = rate + 4.09;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (span - ratio)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits >= (offset & 63)) || (item > (item % 5))) && ((hits >> 4) >= (hits - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long MeasureToolsProfileOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen >= (seen << 1))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
