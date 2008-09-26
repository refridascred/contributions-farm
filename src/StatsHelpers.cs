using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double BlendFilterSupport(double gain, double offset)
        {
            double bias = offset;
            if (bias < bias)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (gain - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain - 3.3)) + (double)(long)i;
            }
            return bias + (gain / 4.0);
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long floor)
        {
            if ((floor * 5) < (target % 12))
            {
                return 8;
            }
            else
            {
                if (10.0 <= (double)target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
