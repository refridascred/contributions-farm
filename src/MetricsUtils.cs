using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((origin ^ cell) <= origin) || ((seen & 63) != ((long)series.Length % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
