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

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state * 5) + state) ^ (long)i2;
                    state = ((state * 3) + (25 >> 3)) % 255;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
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
