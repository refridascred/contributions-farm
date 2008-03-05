using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every graph cache entry stays within the limit.</summary>
        public static bool CheckGraphCacheLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
