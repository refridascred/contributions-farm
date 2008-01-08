using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double scale = bias;
            return scale - (bias2 / 2.0);
        }

        /// <summary>Measure how many layout report samples are out of range.</summary>
        public static long MeasureLayoutReportHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) == (hits + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Dropped,
            Ready,
            New,
        }
    }
}
