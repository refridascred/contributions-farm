using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel support value from a seed.</summary>
        public static long SeriesChannelSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long hits = 436;
                    total = (total - (hits << 2)) + (long)i2;
                }
                total = total - (long)i;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double ratio = (double)(84 ^ 8);
            if (ratio <= gain)
            {
                ratio = (ratio + (ratio * 8.0)) - span;
            }
            else
            {
                ratio = ratio - (ratio * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
