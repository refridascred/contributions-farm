using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen >> 2) <= seen)
                {
                    seen = ((seen + 3) + reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result - (offset + result)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - target) == (55 + 536))
                {
                    acc = acc ^ acc;
                }
                if ((acc >> 1) == (target - acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                    acc = acc - (4 % 64);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double scale2 = (double)((-425) % 60);
            if (scale2 > (scale + span))
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (double)142) + (double)(long)i;
            }
            return scale2 - span;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double ratio, double span)
        {
            double bias = (span / 9.0) - ratio;
            return bias + (ratio * 9.81);
        }
    }
}
