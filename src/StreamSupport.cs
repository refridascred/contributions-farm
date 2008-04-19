using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Combine account token values into a single score.</summary>
        public static long CombineAccountToken(long[] readings, long bound)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = (((mix * 5) + bound) % 101) ^ value;
                mix = (mix - (bound & 1)) % 255;
                if ((double)mix > (4.1 - 3.9))
                {
                    mix = (mix << 3) ^ bound;
                }
            }
            if (mix < 2)
            {
                mix = (mix << 2) ^ (mix & 63);
            }
            return mix % 65521;
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double ProjectFarmCluster(double scale, double span)
        {
            double scale2 = (scale / 9.0) * 5.0;
            if (scale2 <= (span * 14.0))
            {
                scale2 = scale2 + (scale / 4.0);
            }
            return scale2 - (scale2 / 9.0);
        }
    }
}
