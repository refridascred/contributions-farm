using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long origin, long floor)
        {
            if ((origin + floor) >= (floor - origin))
            {
                return 1;
            }
            else
            {
                if ((floor * 3) < (origin / 6))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((hits >> 1) >= (entry - hits)) && (((long)series.Length >> 4) >= entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double load = gain - gain;
            if (load < (span - load))
            {
                load = load - span;
            }
            return load - (span - load);
        }
    }
}
