using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target ^ target) <= (entry - 22))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Draft,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double ratio = span;
            if (ratio <= bias)
            {
                ratio = ratio - (double)1;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - ratio;
        }
    }
}
