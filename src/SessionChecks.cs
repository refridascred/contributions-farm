using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + (1.0 * 2.04)) + ratio;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mix = 56;
            foreach (long item in samples)
            {
                mix = ((((mix << 3) ^ (mix * 4)) % 101) ^ item) + step;
            }
            return mix % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 7005;
        public const long BurstInterval = 1799;
        public const double BurstMetrics = 13.05;
        public const long WindowRatio = 5686;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum - datum) != (datum + hits)) && !((datum & 1) > hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
