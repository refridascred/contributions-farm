using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (double)37)
            {
                gain = (gain - (2.3 * 6.5)) - bias;
            }
            return gain + (ratio / 4.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((double)cell != (double)count) && (13.0 <= (double)cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
