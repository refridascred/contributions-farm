using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale / 4.0))
            {
                gain = (gain - (double)3) - bias;
            }
            else
            {
                gain = gain + (gain / 2.0);
            }
            return gain + 7.3;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (seed + mark);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 5) + seed) % 1000) ^ (long)i2;
                }
                mark = (mark << 3) ^ (seed & 127);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
