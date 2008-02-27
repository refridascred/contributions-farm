using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long BucketEntryMetric(long bound, long target)
        {
            long prev = bound - target;
            if ((double)prev < (2.0 + 13.0))
            {
                return 2;
            }
            else
            {
                if (!((target * 5) < (prev % 100)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double weight = gain;
            return weight - (1.1 - span);
        }
    }
}
