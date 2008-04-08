using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a route token figure with a bias.</summary>
        public static double BlendRouteToken(double bias, double span)
        {
            double drift = span;
            if (drift < (double)94)
            {
                drift = drift - (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - bias)) - (double)(long)i;
            }
            return drift - (drift - bias);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = -10;
            foreach (long reading in values)
            {
                if (((60 - 37) > reading) && ((double)reading < (1.0 - 7.4)))
                {
                    mark = (mark + reading) % 65521;
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 3) + (mark >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double load = (double)26 * 8.3;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + (load - load)) + (double)(long)i) + ratio) - floor;
            }
            return load - (double)14;
        }
    }
}
