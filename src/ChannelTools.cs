using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 1710;
        public const double BaseSpan = 37.5;
        public const long MaxWindow = 2622;
        public const long WindowBudget = 3554;

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
