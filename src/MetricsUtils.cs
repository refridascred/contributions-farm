using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Ready,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((mix ^ (long)i) <= ((long)i - (long)i))
                {
                    mix = (mix + ((long)i << 3)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double bias)
        {
            double scale = 14.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale + scale) + (double)(long)i) - gain) - bias;
            }
            return scale + 7.82;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Locked,
            Done,
            Queued,
        }
    }
}
